using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.Models;
using Punto_de_venta.Controllers;

namespace Punto_de_venta.Views
{
    public partial class ProductsList : Form
    {

        private readonly ProductController _controller;
        public ProductsList(ProductController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.Load += ProductsList_Load;
        }

        private void ProductsList_Load(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                var products = _controller.GetAllProducts().ToList();
                dgvListaProductos.AutoGenerateColumns = true;
                dgvListaProductos.DataSource = products;

                dgvListaProductos.Columns["Name"].HeaderText = "Nombre";
                dgvListaProductos.Columns["Code"].HeaderText = "Código";
                dgvListaProductos.Columns["purchasePrice"].HeaderText = "Precio de compra";
                dgvListaProductos.Columns["salePrice"].HeaderText = "Precio de venta";

                if (!dgvListaProductos.Columns.Contains("Proveedor"))
                {
                    var supplierColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Proveedor",
                        HeaderText = "Proveedor",
                        ReadOnly = true
                    };
                    dgvListaProductos.Columns.Add(supplierColumn);
                }

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    var product = row.DataBoundItem as Product;
                    if (product?.Supplier != null)
                    {
                        row.Cells["Proveedor"].Value = product.Supplier.Name;
                    }
                }

                dgvListaProductos.Columns["Id"].Visible = false;
                dgvListaProductos.Columns["SupplierId"].Visible = false;
                dgvListaProductos.Columns["BuyItems"].Visible = false;
                dgvListaProductos.Columns["SaleItems"].Visible = false;
                dgvListaProductos.Columns["Supplier"].Visible = false;


                if (products.Count == 0)
                    MessageBox.Show("No hay productos registrados");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var productos = _controller.GetAllProducts();

            var coincidencias = productos
                .Where(p => p.Name.ToLower().Contains(filtro) || p.Code.ToLower().Contains(filtro))
                .ToList();
            if (coincidencias.Count > 0)
            {
                lstSugerencias.DataSource = coincidencias;
                lstSugerencias.DisplayMember = "Name";
                lstSugerencias.ValueMember = "Id";
                lstSugerencias.Visible = true;
            }
            else
            {
                lstSugerencias.Visible = false;
            }


        }

        private void lstSugerencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSugerencias_Click(object sender, EventArgs e)
        {
            if (lstSugerencias.SelectedItem == null) return;

            var seleccionado = lstSugerencias.SelectedItem as Product;

            dgvListaProductos.ClearSelection();

            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                var productoFila = row.DataBoundItem as Product;
                if (productoFila != null && productoFila.Id == seleccionado.Id)
                {
                    row.Selected = true;

                    dgvListaProductos.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

        }
    }
}
