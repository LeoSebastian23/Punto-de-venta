using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Punto_de_venta.Views
{
    public partial class SupplierView : Form
    {
        private readonly SupplierController _controller;

        public SupplierView(SupplierController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = _controller.GetAllSuppliers().ToList();
            dgvSuppliers.DataSource = suppliers;
            dgvSuppliers.Columns["Id"].Visible = false;
            dgvSuppliers.Columns["Products"].Visible = false;
            dgvSuppliers.Columns["Buys"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.CreateSupplier(txtName.Text, txtCUIT.Text, txtPhone.Text);
                MessageBox.Show("Proveedor agregado correctamente ✅");
                ClearFields();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0) return;

            var supplier = (Supplier)dgvSuppliers.SelectedRows[0].DataBoundItem;

            try
            {
                _controller.DeleteSupplier(supplier.Id);
                LoadSuppliers();

                MessageBox.Show(
                    "Proveedor eliminado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (InvalidOperationException ex)
            {
                // Error controlado (proveedor con compras/productos asociadas)
                MessageBox.Show(
                    ex.Message,
                    "No se puede eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                // Cualquier otro error inesperado
                MessageBox.Show(
                    "Ocurrió un error al eliminar el proveedor: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtCUIT.Clear();
            txtPhone.Clear();
        }
    }
}
