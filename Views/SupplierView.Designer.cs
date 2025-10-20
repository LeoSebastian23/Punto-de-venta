namespace Punto_de_venta.Views
{
    partial class SupplierView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCUIT = new Label();
            txtCUIT = new TextBox();
            lblNumeroTelefono = new Label();
            txtNumeroTelefono = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            button1 = new Button();
            btnEliminar = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(148, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(239, 130);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(446, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Font = new Font("Segoe UI", 12F);
            lblCUIT.Location = new Point(151, 179);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(69, 28);
            lblCUIT.TabIndex = 2;
            lblCUIT.Text = "C.U.I.T.";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(239, 180);
            txtCUIT.Margin = new Padding(3, 4, 3, 4);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(446, 27);
            txtCUIT.TabIndex = 3;
            // 
            // lblNumeroTelefono
            // 
            lblNumeroTelefono.AutoSize = true;
            lblNumeroTelefono.Font = new Font("Segoe UI", 12F);
            lblNumeroTelefono.Location = new Point(82, 231);
            lblNumeroTelefono.Name = "lblNumeroTelefono";
            lblNumeroTelefono.Size = new Size(151, 28);
            lblNumeroTelefono.TabIndex = 4;
            lblNumeroTelefono.Text = "Nro de teléfono";
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(239, 231);
            txtNumeroTelefono.Margin = new Padding(3, 4, 3, 4);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(446, 27);
            txtNumeroTelefono.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(67, 301);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 53);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(239, 40);
            label1.Name = "label1";
            label1.Size = new Size(446, 54);
            label1.TabIndex = 9;
            label1.Text = "Gestion de Proovedores";
            // 
            // button1
            // 
            button1.Location = new Point(219, 301);
            button1.Name = "button1";
            button1.Size = new Size(133, 53);
            button1.TabIndex = 10;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(372, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 53);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(532, 301);
            button3.Name = "button3";
            button3.Size = new Size(133, 53);
            button3.TabIndex = 12;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(732, 301);
            button4.Name = "button4";
            button4.Size = new Size(133, 53);
            button4.TabIndex = 13;
            button4.Text = "Recargar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 387);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 188);
            dataGridView1.TabIndex = 14;
            // 
            // SupplierView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(lblNumeroTelefono);
            Controls.Add(txtCUIT);
            Controls.Add(lblCUIT);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SupplierView";
            Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCUIT;
        private TextBox txtCUIT;
        private Label lblNumeroTelefono;
        private TextBox txtNumeroTelefono;
        private Button btnGuardar;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button btnEliminar;
    }
}