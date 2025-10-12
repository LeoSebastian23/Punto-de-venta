namespace Punto_de_venta.Views
{
    partial class Supplier
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
            lblListaProductos = new Label();
            cbxListaProductos = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Location = new Point(48, 76);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(45, 15);
            lblCUIT.TabIndex = 2;
            lblCUIT.Text = "C.U.I.T.";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(118, 71);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(206, 23);
            txtCUIT.TabIndex = 3;
            // 
            // lblNumeroTelefono
            // 
            lblNumeroTelefono.AutoSize = true;
            lblNumeroTelefono.Location = new Point(48, 120);
            lblNumeroTelefono.Name = "lblNumeroTelefono";
            lblNumeroTelefono.Size = new Size(114, 15);
            lblNumeroTelefono.TabIndex = 4;
            lblNumeroTelefono.Text = "Número de teléfono";
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(189, 114);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(215, 23);
            txtNumeroTelefono.TabIndex = 5;
            // 
            // lblListaProductos
            // 
            lblListaProductos.AutoSize = true;
            lblListaProductos.Location = new Point(48, 160);
            lblListaProductos.Name = "lblListaProductos";
            lblListaProductos.Size = new Size(104, 15);
            lblListaProductos.TabIndex = 6;
            lblListaProductos.Text = "Lista de productos";
            // 
            // cbxListaProductos
            // 
            cbxListaProductos.FormattingEnabled = true;
            cbxListaProductos.Location = new Point(182, 158);
            cbxListaProductos.Name = "cbxListaProductos";
            cbxListaProductos.Size = new Size(215, 23);
            cbxListaProductos.TabIndex = 7;
            cbxListaProductos.SelectedIndexChanged += cbxListaProductos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(169, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 40);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(cbxListaProductos);
            Controls.Add(lblListaProductos);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(lblNumeroTelefono);
            Controls.Add(txtCUIT);
            Controls.Add(lblCUIT);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Supplier";
            Text = "Supplier";
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
        private Label lblListaProductos;
        private ComboBox cbxListaProductos;
        private Button btnGuardar;
    }
}