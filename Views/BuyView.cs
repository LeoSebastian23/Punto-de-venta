using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Punto_de_venta.Views
{
    public partial class BuyView : Form
    {
        private readonly BuyController _buyController;
        private readonly SupplierController _supplierController;
        private readonly ProductController _productController;
        private readonly ProductView _productView; // 🔹 Vista completa de productos

        private List<(Product product, int quantity, decimal unitCost, decimal margin)> _items
            = new List<(Product, int, decimal, decimal)>();

        public BuyView(
            BuyController buyController,
            SupplierController supplierController,
            ProductController productController,
            ProductView productView) // 🔹 Inyección de la vista de productos
        {
            InitializeComponent();
            _buyController = buyController;
            _supplierController = supplierController;
            _productController = productController;
            _productView = productView;
        }

        private void BuyView_Load(object sender, EventArgs e)
        {
            // Cargar proveedores
            cmbSupplier.DataSource = _supplierController.GetAllSuppliers().ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";

            // Cargar productos
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProducts.DataSource = _productController.GetAllProducts().ToList();

            if (dgvProducts.Columns.Contains("Id"))
                dgvProducts.Columns["Id"].Visible = false;

            dgvProducts.Columns["Stock"].HeaderText = "Stock";
            dgvProducts.Columns["SalePrice"].HeaderText = "Precio Venta";
        }

        // 🔹 Doble click en un producto
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AgregarItemDesdeSeleccion();
        }

        // 🔹 Botón "Agregar Ítem"
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                var result = MessageBox.Show(
                    "No seleccionaste ningún producto. ¿Querés crear uno nuevo?",
                    "Producto no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 🔹 Abre la vista completa de productos
                    _productView.ShowDialog();

                    // 🔹 Refresca el listado al volver
                    CargarProductos();
                }

                return;
            }

            // 🔹 Si hay producto seleccionado, agregamos el ítem normalmente
            var product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
            var modal = new LoadBuyItem(_buyController, product);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                _items.Add((modal.Product, modal.Quantity, modal.UnitCost, modal.Margin));
                dgvItems.Rows.Add(product.Name, modal.Quantity, modal.UnitCost, modal.Margin,
                    modal.Quantity * modal.UnitCost);
            }
        }

        // 🔹 Método auxiliar reutilizable
        private void AgregarItemDesdeSeleccion()
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para agregar.");
                return;
            }

            var product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
            var modal = new LoadBuyItem(_buyController, product);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                _items.Add((modal.Product, modal.Quantity, modal.UnitCost, modal.Margin));
                dgvItems.Rows.Add(product.Name, modal.Quantity, modal.UnitCost, modal.Margin,
                    modal.Quantity * modal.UnitCost);
            }
        }

        // 🔹 Registrar compra
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un ítem antes de registrar la compra.");
                return;
            }

            var supplier = (Supplier)cmbSupplier.SelectedItem;
            string invoiceNumber = txtInvoice.Text.Trim();
            string invoiceType = cmbInvoiceType.SelectedItem?.ToString() ?? "B";

            var itemsSend = _items.Select(x => (x.product, x.quantity, x.unitCost)).ToList();

            _buyController.RegisterBuy(supplier, invoiceNumber, itemsSend, invoiceType);

            MessageBox.Show("Compra registrada correctamente ✅");

            dgvItems.Rows.Clear();
            _items.Clear();
        }
    }
}



