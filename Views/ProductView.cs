using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Punto_de_venta.Views
{
    public partial class ProductView : Form
    {
        private readonly ProductController _controller;

        public ProductView(ProductController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            LoadProducts();

            numMargin.ValueChanged += (s, ev) => RecalculateSalePrice();
            numSalePrice.ValueChanged += (s, ev) => RecalculateMargin();

            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
        }

        private void LoadProducts()
        {
            var products = _controller.GetAllProducts().ToList();
            dgvProducts.DataSource = products;

            dgvProducts.Columns["Id"].Visible = false;

            // Evitar duplicar columnas de botones
            if (!dgvProducts.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "EditColumn";
                btnEdit.HeaderText = "Editar";
                btnEdit.Text = "✏️";
                btnEdit.Width = 60;
                btnEdit.UseColumnTextForButtonValue = true;
                dgvProducts.Columns.Add(btnEdit);
            }

            if (!dgvProducts.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "DeleteColumn";
                btnDelete.HeaderText = "Eliminar";
                btnDelete.Text = "🗑️";
                btnDelete.Width = 70;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvProducts.Columns.Add(btnDelete);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salePrice = numSalePrice.Value;
                int stock = (int)numStock.Value;

                _controller.CreateProduct(
                    txtName.Text,
                    txtCode.Text,
                    salePrice,
                    stock
                );

                MessageBox.Show("Producto agregado correctamente.");
                ClearFields();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtCode.Clear();
            numSalePrice.Value = 0;
            numMargin.Value = 0;
            numStock.Value = 0;
        }

        private void RecalculateSalePrice()
        {
            if (numBaseCost.Value <= 0) return;

            decimal baseCost = numBaseCost.Value;
            decimal margin = numMargin.Value;

            numSalePrice.Value = baseCost + (baseCost * (margin / 100));
        }

        private void RecalculateMargin()
        {
            if (numBaseCost.Value <= 0) return;

            decimal baseCost = numBaseCost.Value;
            decimal salePrice = numSalePrice.Value;

            if (salePrice <= baseCost)
            {
                numMargin.Value = 0;
                return;
            }

            decimal margin = ((salePrice - baseCost) / baseCost) * 100;
            numMargin.Value = margin;
        }

        private void numBaseCost_ValueChanged(object sender, EventArgs e)
        {
            decimal valor = numBaseCost.Value;
            lblCostobse.Text = "$" + valor.ToString("N2");
        }


        // === NUEVO === Evento al seleccionar fila
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
                return;

            var product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            txtName.Text = product.Name;
            txtCode.Text = product.Code;
            numSalePrice.Value = product.SalePrice;
            numStock.Value = product.Stock;
        }


        // === NUEVO === Manejo de EDITAR y ELIMINAR desde el DataGrid
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var product = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

            // ---- EDITAR ----
            if (dgvProducts.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                // Seleccionar la fila correctamente
                dgvProducts.ClearSelection();
                dgvProducts.Rows[e.RowIndex].Selected = true;

                // Obtener el producto
                var productToEdit = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

                // Cargar datos a los campos
                txtName.Text = productToEdit.Name;
                txtCode.Text = productToEdit.Code;
                numSalePrice.Value = productToEdit.SalePrice;
                numStock.Value = productToEdit.Stock;

                MessageBox.Show("Edite los campos y luego presione 'Actualizar producto'.");
                return;
            }

            // ---- ELIMINAR ----
            if (dgvProducts.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro desea eliminar el producto '{product.Name}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                try
                {
                    _controller.DeleteProduct(product.Id);
                    MessageBox.Show("Producto eliminado correctamente.");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "No se pudo eliminar el producto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            var product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            try
            {
                _controller.UpdateProduct(
                    product.Id,
                    txtName.Text,
                    txtCode.Text,
                    numSalePrice.Value,
                    (int)numStock.Value
                );

                MessageBox.Show("Producto actualizado correctamente.");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}
