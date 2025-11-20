using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Windows.Forms;

using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Windows.Forms;

namespace Punto_de_venta.Views
{
    public partial class LoadBuyItem : Form
    {
        private bool isUpdating;

        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }
        public decimal SalePrice { get; private set; }
        public decimal Margin { get; private set; }

        public LoadBuyItem(BuyController controller, Product product)
        {
            InitializeComponent();
            Product = product;
        }

        private void LoadBuyItem_Load(object sender, EventArgs e)
        {
            txtProduct.Text = Product.Name;

            // Eventos para recalcular margen o precio automáticamente
            numCost.ValueChanged += UpdateMarginOrPrice;
            numSalePrice.ValueChanged += UpdateMarginOrPrice;
            numMargin.ValueChanged += UpdateSalePriceFromMargin;
        }

        private void UpdateMarginOrPrice(object sender, EventArgs e)
        {
            if (isUpdating) return;
            isUpdating = true;

            try
            {
                decimal cost = numCost.Value;

                // Si están editando el margen → recalcular precio
                if (sender == numMargin)
                {
                    decimal margin = numMargin.Value;

                    if (margin < 0) margin = 0;   // BLOQUEAR Margen negativo
                    numMargin.Value = margin;

                    decimal salePrice = cost * (1 + margin / 100);
                    if (salePrice < 0) salePrice = 0; // Seguridad extra

                    numSalePrice.Value = salePrice;
                }

                // Si están editando el precio → recalcular margen
                if (sender == numSalePrice)
                {
                    decimal sale = numSalePrice.Value;

                    if (sale < cost)
                    {
                        sale = cost; // El precio no puede ser menor al costo
                        numSalePrice.Value = sale;
                    }

                    decimal margin = cost == 0 ? 0 : ((sale - cost) / cost) * 100;

                    if (margin < 0) margin = 0; // Margen negativo prohibido

                    numMargin.Value = margin > numMargin.Maximum ? numMargin.Maximum : margin;
                }
            }
            finally
            {
                isUpdating = false;
            }
        }


        private void UpdateSalePriceFromMargin(object sender, EventArgs e)
        {
            if (numCost.Value <= 0)
                return;

            // Recalcular precio según margen ingresado
            numSalePrice.Value = numCost.Value * (1 + numMargin.Value / 100);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Quantity = (int)numQuantity.Value;
            UnitCost = numCost.Value;
            SalePrice = numSalePrice.Value;
            Margin = numMargin.Value;

            if (Quantity <= 0 || UnitCost <= 0)
            {
                MessageBox.Show("Cantidad y costo deben ser mayores a 0.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

