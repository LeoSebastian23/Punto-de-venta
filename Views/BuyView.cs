using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.Controllers;
using Punto_de_venta.Models;


namespace Punto_de_venta.Views
{
    public partial class BuyView : Form
    {

        private readonly BuyController _buyController;
        private readonly ProductController _productController;
        private readonly SupplierController _supplierController;
        public BuyView(BuyController buyController, ProductController productController, SupplierController supplierController)
        {
            InitializeComponent();
            _buyController = buyController;
            _productController = productController;
            _supplierController = supplierController;
            LoadBuys();

        }

        private void LoadBuys()
        {
            dgvCompra.AutoGenerateColumns = true;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var productos = _productController.GetAllProducts();

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

            /*dgvCompra.ClearSelection();

            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                var productoFila = row.DataBoundItem as Product;
                if (productoFila != null && productoFila.Id == seleccionado.Id)
                {
                    row.Selected = true;

                    dgvCompra.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }*/

            if (seleccionado != null)
            {
                var loadBuyItem = new LoadBuyItem(_buyController, seleccionado);
                loadBuyItem.ShowDialog();
            }


        }

        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var suppliers = _supplierController.GetAllSuppliers().ToList();

                if (suppliers == null || suppliers.Count == 0)
                {
                    MessageBox.Show("No hay proveedores disponibles.");
                    return;
                }

                comboSupplier.DataSource = suppliers;
                comboSupplier.DisplayMember = "Name";
                comboSupplier.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
        }

    }
}
