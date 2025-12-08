using Punto_de_venta.Controllers;
using Punto_de_venta.Models;


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

            ConfigureDeleteColumn();
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

            string invoiceNumber = txtInvoice.Text.Trim();

            // VALIDACIÓN OBLIGATORIA
            if (string.IsNullOrWhiteSpace(invoiceNumber))
            {
                MessageBox.Show(
                    "Debe completar el número de ticket para continuar.",
                    "Número de ticket obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtInvoice.Focus();
                return;
            }

            var supplier = (Supplier)cmbSupplier.SelectedItem;
            string invoiceType = cmbInvoiceType.SelectedItem?.ToString() ?? "B";

            var itemsSend = _items.Select(x => (x.product, x.quantity, x.unitCost)).ToList();

            _buyController.RegisterBuy(supplier, invoiceNumber, itemsSend, invoiceType);

            MessageBox.Show("Compra registrada correctamente ✅");

            dgvItems.Rows.Clear();
            _items.Clear();
        }


        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            _productView.ShowDialog();  // usa la instancia inyectada correctamente
            CargarProductos();          // refresca la grilla
        }


        private void btnVerCompras_Click(object sender, EventArgs e)
        {
            var view = new BuysListView(_buyController);
            view.ShowDialog();
        }

        private void ConfigureDeleteColumn()
        {
            if (!dgvItems.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "DeleteColumn";
                btnDelete.HeaderText = "Eliminar";
                btnDelete.Text = "🗑️";
                btnDelete.Width = 70;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvItems.Columns.Add(btnDelete);
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezado o fuera de rango
            if (e.RowIndex < 0)
                return;

            // Verificar que la columna sea la correcta
            if (dgvItems.Columns[e.ColumnIndex].Name != "DeleteColumn")
                return;

            // Validar que el índice exista en la lista
            if (e.RowIndex >= _items.Count)
            {
                MessageBox.Show("El ítem no existe en la lista interna. Refrescando tabla.");
                dgvItems.Rows.Clear();

                // Recargar items visibles nuevamente (RECOMENDADO)
                foreach (var x in _items)
                {
                    dgvItems.Rows.Add(x.product.Name, x.quantity, x.unitCost, x.margin, x.quantity * x.unitCost);
                }

                return;
            }

            var confirm = MessageBox.Show(
                $"¿Seguro desea eliminar el producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            // Eliminar de la lista interna
            _items.RemoveAt(e.RowIndex);

            // Eliminar de la grilla
            dgvItems.Rows.RemoveAt(e.RowIndex);
        }

    }
}



