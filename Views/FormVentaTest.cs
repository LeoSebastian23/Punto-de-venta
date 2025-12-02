using System;
using System.Linq;
using System.Windows.Forms;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Controllers;

namespace Punto_de_venta.Views
{
    public partial class FormVentaTest : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly SaleController _saleController;

        private Sale _currentSale;


        public FormVentaTest(
            IProductRepository productRepository,
            SaleController saleController)
        {
            _productRepository = productRepository;
            _saleController = saleController;

            InitializeComponent();
            _currentSale = new Sale();

            this.AcceptButton = btnAgregar;


        }

        private void FormVentaTest_Load(object sender, EventArgs e)
        {
            ConfigureListView();
            UpdateTotal();
            CreateEditTextBox();
        }

        private void ConfigureListView()
        {
            //cambios que hago ahora
            lvItems.View = View.Details;
            lvItems.FullRowSelect = true;
            lvItems.GridLines = true;
            lvItems.LabelEdit = true;

            ///
            lvItems.Columns.Clear();
            lvItems.Columns.Add("Producto", 150);
            lvItems.Columns.Add("Cantidad", 80);
            lvItems.Columns.Add("P. Unitario", 100);
            lvItems.Columns.Add("Subtotal", 100);



            /*lvItems.View = View.Details;
            lvItems.FullRowSelect = true;*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string code = txtCodigo.Text.Trim();
            int quantity = (int)nudCantidad.Value;

            var product = _productRepository.GetByCode(code);

            if (product == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            // Opción: permitir stock negativo como indicaste
            if (product.Stock < quantity)
            {
                MessageBox.Show($"Stock insuficiente ({product.Stock}). Se permite continuar si querés restar stock negativo.");
                // Podés eliminar este return si querés permitir venta con stock negativo
                return;
            }

            // Trabajamos con objetos
            _currentSale.AddItem(product, quantity);

            RefreshItemsList();
            UpdateTotal();
            txtCodigo.Clear();
            nudCantidad.Value = 1;
        }

        private void RefreshItemsList()
        {
            lvItems.Items.Clear();

            foreach (var item in _currentSale.Items)
            {
                var lvi = new ListViewItem(item.Product?.Name ?? "Producto eliminado");
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.UnitPrice.ToString("0.00"));
                lvi.SubItems.Add(item.Subtotal.ToString("0.00"));

                lvItems.Items.Add(lvi);
            }
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"Total: {_currentSale.TotalAmount:0.00}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!_currentSale.Items.Any())
            {
                MessageBox.Show("La venta no tiene ítems.");
                return;
            }

            try
            {
                // Esto ahora dispara la cadena completa:
                // UI → Controller → Service → Repository → EF → DB
                _saleController.CreateSale(_currentSale);

                MessageBox.Show("Venta registrada correctamente.");

                _currentSale = new Sale();
                RefreshItemsList();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al confirmar la venta:\n{ex.Message}\n\nDetalle:\n{ex.InnerException?.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            var view = new ImprimirTicketView();
            view.ShowDialog();

        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvItems.SelectedItems[0];

            int subIndex = 1;

            Rectangle rect = item.SubItems[subIndex].Bounds;

            txtEdit.SetBounds(
                rect.X,
                rect.Y,
                rect.Width,
                rect.Height
            );

            txtEdit.Text = item.SubItems[subIndex].Text;
            txtEdit.Tag = item;
            txtEdit.Visible = true;
            txtEdit.Focus();
            txtEdit.SelectAll();

        }

        private void TxtEdit_Leave(object sender, EventArgs e)
        {
            SaveEdit();
        }

        private void TxtEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveEdit();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void CreateEditTextBox()
        {
            txtEdit = new TextBox();
            txtEdit.Visible = false;
            txtEdit.Leave += TxtEdit_Leave;
            txtEdit.KeyDown += TxtEdit_KeyDown;

            lvItems.Controls.Add(txtEdit);
        }

        private void SaveEdit()
        {
            if (txtEdit.Tag is ListViewItem item)
            {
                int index = item.Index;

                if (int.TryParse(txtEdit.Text, out int newQty) && newQty > 0)
                {
                    var oldItem = _currentSale.Items[index];



                }
            }


            txtEdit.Visible = false;
            txtEdit.Tag = null;

            UpdateTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanControls(this);
            CleanLvItems();
            _currentSale = new Sale();
            UpdateTotal();
        }

        private void CleanControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is MaskedTextBox) ((MaskedTextBox)c).Clear();
                if (c is RichTextBox) ((RichTextBox)c).Clear();
                if (c is ListView list && list.Name == "lvItems")
                    list.Items.Clear();
                if (c.HasChildren)
                    CleanControls(c);
            }
        }

        private void CleanLvItems()
        {
            lvItems.Items.Clear();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
