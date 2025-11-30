namespace Punto_de_venta.Views
{
    partial class SupplierView
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvSuppliers;
        private TextBox txtName;
        private TextBox txtCUIT;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblName, lblCUIT, lblPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvSuppliers = new DataGridView();
            txtName = new TextBox();
            txtCUIT = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblCUIT = new Label();
            lblPhone = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvSuppliers.ColumnHeadersHeight = 29;
            dgvSuppliers.Location = new Point(20, 189);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(400, 262);
            dgvSuppliers.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 27);
            txtName.TabIndex = 1;
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(126, 60);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(154, 27);
            txtCUIT.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(126, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 27);
            txtPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.Location = new Point(20, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(327, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre:";
            // 
            // lblCUIT
            // 
            lblCUIT.Location = new Point(20, 60);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(100, 23);
            lblCUIT.TabIndex = 2;
            lblCUIT.Text = "CUIT:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Teléfono:";
            // 
            // SupplierView
            // 
            ClientSize = new Size(594, 481);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCUIT);
            Controls.Add(txtCUIT);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvSuppliers);
            Name = "SupplierView";
            Text = "Proveedores";
            Load += SupplierView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
