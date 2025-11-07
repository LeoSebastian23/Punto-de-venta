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
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(100, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(38, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 29);
            txtNombre.TabIndex = 1;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Font = new Font("Segoe UI", 12F);
            lblCUIT.Location = new Point(360, 72);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(55, 21);
            lblCUIT.TabIndex = 2;
            lblCUIT.Text = "C.U.I.T.";
            // 
            // txtCUIT
            // 
            txtCUIT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCUIT.Location = new Point(337, 96);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(201, 29);
            txtCUIT.TabIndex = 3;
            // 
            // lblNumeroTelefono
            // 
            lblNumeroTelefono.AutoSize = true;
            lblNumeroTelefono.Font = new Font("Segoe UI", 12F);
            lblNumeroTelefono.Location = new Point(653, 72);
            lblNumeroTelefono.Name = "lblNumeroTelefono";
            lblNumeroTelefono.Size = new Size(119, 21);
            lblNumeroTelefono.TabIndex = 4;
            lblNumeroTelefono.Text = "Nro de teléfono";
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroTelefono.Location = new Point(618, 96);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(201, 29);
            txtNumeroTelefono.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 9;
            label1.Text = "Crear Proveedores";
            label1.Click += label1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(134, 142);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.Location = new Point(290, 142);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(861, 185);
            dataGridView1.TabIndex = 12;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 192, 0);
            btnActualizar.Location = new Point(570, 142);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 41);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 0, 192);
            btnEliminar.Location = new Point(716, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 41);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // SupplierView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 406);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(lblNumeroTelefono);
            Controls.Add(txtCUIT);
            Controls.Add(lblCUIT);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
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
        private Label label1;
        private Button button2;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}