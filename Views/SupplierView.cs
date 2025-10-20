using Punto_de_venta.Controllers;
using Punto_de_venta.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Punto_de_venta.Views
{
    public partial class SupplierView : Form
    {
        private readonly SupplierController _controller;

        //  El controlador se inyecta por constructor (gracias al ServiceProvider en Program.cs)
        public SupplierView(SupplierController controller)
        {
            InitializeComponent();
            _controller = controller;
            LoadSuppliers();
        }

        // Cargar lista de proveedores al iniciar o refrescar
        private void LoadSuppliers()
        {
            var suppliers = _controller.GetAllSuppliers();
            dataGridView1.DataSource = suppliers.ToList();
        }

        // Guardar nuevo proveedor
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string cuit = txtCUIT.Text;
                string phoneNumber = txtNumeroTelefono.Text;

                _controller.CreateSupplier(nombre, cuit, phoneNumber);
                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualizar proveedor seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar.");
                return;
            }

            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            string phoneNumber = txtNumeroTelefono.Text;
            string nombre = txtNombre.Text;

            _controller.UpdateSupplier(id, nombre, phoneNumber);
            MessageBox.Show("Proveedor actualizado.");
            LoadSuppliers();
        }

        // Eliminar proveedor
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
                return;
            }

            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

            try
            {
                _controller.DeleteSupplier(id);
                MessageBox.Show("Proveedor eliminado correctamente.");
                LoadSuppliers();
            }
            catch (InvalidOperationException ex)
            {
                // ⚠️ Error de negocio: proveedor con productos asociados
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // ❌ Error inesperado
                MessageBox.Show("Ocurrió un error al eliminar el proveedor: " + ex.Message);
            }
        }

        // Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtNombre.Text = "";
            txtCUIT.Text = "";
            txtNumeroTelefono.Text = "";
        }

        // Refrescar lista manualmente
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        // Mostrar proveedor al seleccionar una fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridView1.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["Name"].Value.ToString();
                txtCUIT.Text = fila.Cells["Cuit"].Value.ToString();
                txtNumeroTelefono.Text = fila.Cells["phoneNumber"].Value.ToString();
            }
        }
    }
}
