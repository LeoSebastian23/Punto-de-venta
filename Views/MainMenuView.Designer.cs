namespace Punto_de_venta.Views
{
    partial class MainMenuView
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSuppliers, btnProducts, btnBuys, btnTestVentas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnBuys = new Button();
            btnTestVentas = new Button();

            // -----------------------------
            // Proveedores
            // -----------------------------
            btnSuppliers.Text = "Proveedores";
            btnSuppliers.Location = new System.Drawing.Point(50, 40);
            btnSuppliers.Size = new System.Drawing.Size(150, 40);
            btnSuppliers.Click += btnSuppliers_Click;

            // -----------------------------
            // Productos
            // -----------------------------
            btnProducts.Text = "Productos";
            btnProducts.Location = new System.Drawing.Point(50, 100);
            btnProducts.Size = new System.Drawing.Size(150, 40);
            btnProducts.Click += btnProducts_Click;

            // -----------------------------
            // Registrar Compra
            // -----------------------------
            btnBuys.Text = "Registrar Compra";
            btnBuys.Location = new System.Drawing.Point(50, 160);
            btnBuys.Size = new System.Drawing.Size(150, 40);
            btnBuys.Click += btnBuys_Click;

            // -----------------------------
            // Test Ventas
            // -----------------------------
            btnTestVentas.Text = "Test Ventas";
            btnTestVentas.Location = new System.Drawing.Point(50, 220);
            btnTestVentas.Size = new System.Drawing.Size(150, 40);
            btnTestVentas.Click += btnTestVentas_Click;

            // -----------------------------
            // FORM
            // -----------------------------
            ClientSize = new System.Drawing.Size(250, 300);
            Controls.AddRange(new Control[]
            {
                btnSuppliers,
                btnProducts,
                btnBuys,
                btnTestVentas
            });

            Text = "Menú Principal";
        }
    }
}

