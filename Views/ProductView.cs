using Punto_de_venta.Controllers;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Punto_de_venta.Views
{
    public partial class ProductView : Form
    {
        private readonly ProductController _controller;

        public ProductView(ProductController controller)
        {
            InitializeComponent();
            _controller = controller;
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _controller.GetAllProducts().ToList();
            dataGridViewProducts.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Code,
                p.PurchasePrice,
                p.SalePrice,
                p.Stock,
                Supplier = p.Supplier?.Name ?? "—"
            }).ToList();
        }

        private void btnAdd_Click2(object sender, EventArgs e)
        {
            try
            {
                string name = LbeltxtName.Text.Trim();
                string code = LbeltxtCode.Text.Trim();
                decimal purchasePrice = decimal.Parse(LbeltxtPurchasePrice.Text);
                decimal salePrice = decimal.Parse(txtSalePrice.Text);
                int stock = int.Parse(txtStock.Text);
                int? supplierId = string.IsNullOrWhiteSpace(txtSupplierId.Text)
                    ? null
                    : int.Parse(txtSupplierId.Text);

                _controller.CreateProduct(name, code, purchasePrice, salePrice, stock, supplierId);
                MessageBox.Show("✅ Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridViewProducts.SelectedRows[0].Cells["Id"].Value;

            try
            {
                _controller.DeleteProduct(id);
                MessageBox.Show("🗑️ Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ No se puede eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void ClearFields()
        {
            //LbeltxtName.Clear();
            //LbeltxtCode.Clear();
            //LbeltxtPurchasePrice.Clear();
            txtSalePrice.Clear();
            txtStock.Clear();
            txtSupplierId.Clear();
        }

    }
}

