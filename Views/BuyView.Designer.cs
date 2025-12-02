namespace Punto_de_venta.Views
{
    partial class BuyView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.ComboBox cmbInvoiceType;

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvItems;

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRegistrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblInvoice = new Label();
            txtInvoice = new TextBox();
            lblInvoiceType = new Label();
            cmbInvoiceType = new ComboBox();
            dgvProducts = new DataGridView();
            dgvItems = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnAddItem = new Button();
            btnRegistrar = new Button();
            btnCrearProducto = new Button();
            btnVerCompras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblSupplier
            // 
            lblSupplier.Location = new Point(20, 20);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 23);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Proveedor:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.Location = new Point(120, 20);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(250, 23);
            cmbSupplier.TabIndex = 1;
            // 
            // lblInvoice
            // 
            lblInvoice.Location = new Point(20, 65);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(94, 23);
            lblInvoice.TabIndex = 2;
            lblInvoice.Text = "Nro Factura:";
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(120, 60);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(150, 23);
            txtInvoice.TabIndex = 3;
            // 
            // lblInvoiceType
            // 
            lblInvoiceType.Location = new Point(300, 60);
            lblInvoiceType.Name = "lblInvoiceType";
            lblInvoiceType.Size = new Size(44, 23);
            lblInvoiceType.TabIndex = 4;
            lblInvoiceType.Text = "Tipo:";
            // 
            // cmbInvoiceType
            // 
            cmbInvoiceType.Items.AddRange(new object[] { "A", "B", "E" });
            cmbInvoiceType.Location = new Point(350, 60);
            cmbInvoiceType.Name = "cmbInvoiceType";
            cmbInvoiceType.Size = new Size(70, 23);
            cmbInvoiceType.TabIndex = 5;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Location = new Point(20, 110);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(498, 264);
            dgvProducts.TabIndex = 6;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // dgvItems
            // 
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvItems.ColumnHeadersHeight = 29;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvItems.Location = new Point(540, 110);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(756, 264);
            dgvItems.TabIndex = 8;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Costo";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Margen";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddItem.BackColor = SystemColors.ActiveCaption;
            btnAddItem.Location = new Point(12, 430);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(150, 35);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "➕ Agregar Ítem";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Location = new Point(1069, 425);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 40);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar Compra";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.BackColor = Color.DarkCyan;
            btnCrearProducto.Location = new Point(209, 430);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(150, 35);
            btnCrearProducto.TabIndex = 10;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = false;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // btnVerCompras
            // 
            btnVerCompras.BackColor = Color.MediumSlateBlue;
            btnVerCompras.Location = new Point(417, 430);
            btnVerCompras.Name = "btnVerCompras";
            btnVerCompras.Size = new Size(150, 35);
            btnVerCompras.TabIndex = 11;
            btnVerCompras.Text = "Ver compras";
            btnVerCompras.UseVisualStyleBackColor = false;
            btnVerCompras.Click += btnVerCompras_Click;
            // 
            // BuyView
            // 
            ClientSize = new Size(1339, 536);
            Controls.Add(btnVerCompras);
            Controls.Add(btnCrearProducto);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblInvoice);
            Controls.Add(txtInvoice);
            Controls.Add(lblInvoiceType);
            Controls.Add(cmbInvoiceType);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddItem);
            Controls.Add(dgvItems);
            Controls.Add(btnRegistrar);
            Name = "BuyView";
            Text = "Registrar Compra";
            Load += BuyView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btnCrearProducto;
        private Button btnVerCompras;
    }
}

