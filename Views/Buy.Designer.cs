namespace Punto_de_venta.Views
{
    partial class Buy
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
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblProveedor = new Label();
            txtProveedor = new TextBox();
            lblNumeroFactura = new Label();
            txtNumeroFactura = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblCostoUnitario = new Label();
            txtCostoUnitario = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(34, 21);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(115, 18);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(232, 23);
            txtProducto.TabIndex = 1;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(35, 198);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 2;
            lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(119, 195);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(228, 23);
            txtProveedor.TabIndex = 3;
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.AutoSize = true;
            lblNumeroFactura.Location = new Point(35, 237);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(79, 15);
            lblNumeroFactura.TabIndex = 4;
            lblNumeroFactura.Text = "Nº de Factura";
            lblNumeroFactura.Click += label2_Click;
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(129, 234);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(240, 23);
            txtNumeroFactura.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(34, 71);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(115, 63);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(109, 23);
            txtCantidad.TabIndex = 7;
            // 
            // lblCostoUnitario
            // 
            lblCostoUnitario.AutoSize = true;
            lblCostoUnitario.Location = new Point(34, 118);
            lblCostoUnitario.Name = "lblCostoUnitario";
            lblCostoUnitario.Size = new Size(82, 15);
            lblCostoUnitario.TabIndex = 8;
            lblCostoUnitario.Text = "Costo unitario";
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(129, 110);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(184, 23);
            txtCostoUnitario.TabIndex = 9;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(34, 160);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(100, 154);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(213, 23);
            dtpFecha.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(202, 285);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(194, 47);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtCostoUnitario);
            Controls.Add(lblCostoUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNumeroFactura);
            Controls.Add(lblNumeroFactura);
            Controls.Add(txtProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Name = "Buy";
            Text = "Buy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProducto;
        private Label lblProveedor;
        private TextBox txtProveedor;
        private Label lblNumeroFactura;
        private TextBox txtNumeroFactura;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblCostoUnitario;
        private TextBox txtCostoUnitario;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
    }
}