using System;
using System.Windows.Forms;
using Punto_de_venta.Models;

namespace Punto_de_venta.Views
{
    public partial class FormVentaDetalleView : Form
    {
        private Sale _sale;

        public FormVentaDetalleView(Sale sale)
        {
            _sale = sale;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblFecha.Text = $"Fecha: {_sale.Date:dd/MM/yyyy HH:mm}";
            lblTotal.Text = $"Total: {_sale.TotalAmount:0.00}";

            lvItems.Items.Clear();

            foreach (var item in _sale.Items)
            {
                var lvi = new ListViewItem(item.Product?.Name ?? "Producto eliminado");
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.UnitPrice.ToString("0.00"));
                lvi.SubItems.Add(item.Subtotal.ToString("0.00"));

                lvItems.Items.Add(lvi);
            }
        }
    }
}
