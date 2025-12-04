using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Punto_de_venta.Models;

namespace Punto_de_venta.Views
{
    public partial class FormVentasListView : Form
    {
        public FormVentasListView(string titulo, IEnumerable<Sale> ventas)
        {
            InitializeComponent();

            Text = titulo;
            LoadVentas(ventas);

            lvVentas.DoubleClick += LvVentas_DoubleClick;
        }


        private void LoadVentas(IEnumerable<Sale> ventas)
        {
            lvVentas.Items.Clear();

            foreach (var sale in ventas)
            {
                var item = new ListViewItem(sale.Date.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(sale.Items.Count.ToString());
                item.SubItems.Add(sale.TotalAmount.ToString("0.00"));

                item.Tag = sale; // Guardamos el objeto completo

                lvVentas.Items.Add(item);
            }
        }

        private void LvVentas_DoubleClick(object sender, EventArgs e)
        {
            if (lvVentas.SelectedItems.Count == 0)
                return;

            var selected = lvVentas.SelectedItems[0];
            var sale = selected.Tag as Sale;

            if (sale == null)
                return;

            var detailView = new FormVentaDetalleView(sale);
            detailView.ShowDialog();
        }


    }
}
