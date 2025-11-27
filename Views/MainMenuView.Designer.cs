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
            SuspendLayout();
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = SystemColors.ActiveCaption;
            btnSuppliers.Location = new Point(50, 40);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(150, 40);
            btnSuppliers.TabIndex = 0;
            btnSuppliers.Text = "Proveedores";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ActiveCaption;
            btnProducts.Location = new Point(50, 100);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(150, 40);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Productos";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnBuys
            // 
            btnBuys.BackColor = SystemColors.ActiveCaption;
            btnBuys.Location = new Point(50, 160);
            btnBuys.Name = "btnBuys";
            btnBuys.Size = new Size(150, 40);
            btnBuys.TabIndex = 2;
            btnBuys.Text = "Registrar Compra";
            btnBuys.UseVisualStyleBackColor = false;
            btnBuys.Click += btnBuys_Click;
            // 
            // btnTestVentas
            // 
            btnTestVentas.BackColor = SystemColors.ActiveCaption;
            btnTestVentas.Location = new Point(50, 220);
            btnTestVentas.Name = "btnTestVentas";
            btnTestVentas.Size = new Size(150, 40);
            btnTestVentas.TabIndex = 3;
            btnTestVentas.Text = "Test Ventas";
            btnTestVentas.UseVisualStyleBackColor = false;
            btnTestVentas.Click += btnTestVentas_Click;
            // 
            // MainMenuView
            // 
            ClientSize = new Size(250, 300);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnBuys);
            Controls.Add(btnTestVentas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenuView";
            Text = "Menú Principal";
            ResumeLayout(false);
        }
    }
}

