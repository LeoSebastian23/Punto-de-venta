namespace Punto_de_venta.Views
{
    partial class MainMenuView
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSuppliers, btnProducts, btnBuys;

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

            btnSuppliers.Text = "Proveedores";
            btnSuppliers.Location = new System.Drawing.Point(50, 40);
            btnSuppliers.Size = new System.Drawing.Size(150, 40);
            btnSuppliers.Click += btnSuppliers_Click;

            btnProducts.Text = "Productos";
            btnProducts.Location = new System.Drawing.Point(50, 100);
            btnProducts.Size = new System.Drawing.Size(150, 40);
            btnProducts.Click += btnProducts_Click;

            btnBuys.Text = "Registrar Compra";
            btnBuys.Location = new System.Drawing.Point(50, 160);
            btnBuys.Size = new System.Drawing.Size(150, 40);
            btnBuys.Click += btnBuys_Click;

            ClientSize = new System.Drawing.Size(250, 240);
            Controls.AddRange(new Control[] { btnSuppliers, btnProducts, btnBuys });
            Text = "Menú Principal";
        }
    }
}
