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
        }

        private void LoadProducts()
        {
            var products = _controller.GetAllProducts().ToList();
            dgvProducts.DataSource = products;

            dgvProducts.Columns["Id"].Visible = false;
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
    }
}





