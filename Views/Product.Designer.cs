namespace Punto_de_venta.Views
{
    partial class Product
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblPrecioCompra = new Label();
            txtPrecioCompra = new TextBox();
            lblMargenGanancia = new Label();
            txtMargenGanancia = new TextBox();
            lblPrecioVenta = new Label();
            textBox1 = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblName_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(123, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(50, 79);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(122, 73);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(228, 23);
            txtCodigo.TabIndex = 3;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(50, 122);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(100, 15);
            lblPrecioCompra.TabIndex = 4;
            lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(165, 114);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(249, 23);
            txtPrecioCompra.TabIndex = 5;
            // 
            // lblMargenGanancia
            // 
            lblMargenGanancia.AutoSize = true;
            lblMargenGanancia.Location = new Point(50, 163);
            lblMargenGanancia.Name = "lblMargenGanancia";
            lblMargenGanancia.Size = new Size(115, 15);
            lblMargenGanancia.TabIndex = 6;
            lblMargenGanancia.Text = "Margen de ganancia";
            // 
            // txtMargenGanancia
            // 
            txtMargenGanancia.Location = new Point(186, 157);
            txtMargenGanancia.Name = "txtMargenGanancia";
            txtMargenGanancia.Size = new Size(245, 23);
            txtMargenGanancia.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(50, 203);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(88, 15);
            lblPrecioVenta.TabIndex = 8;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 9;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(50, 240);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(111, 234);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(126, 23);
            txtStock.TabIndex = 11;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(160, 287);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(168, 47);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(textBox1);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtMargenGanancia);
            Controls.Add(lblMargenGanancia);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblPrecioCompra);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblPrecioCompra;
        private TextBox txtPrecioCompra;
        private Label lblMargenGanancia;
        private TextBox txtMargenGanancia;
        private Label lblPrecioVenta;
        private TextBox textBox1;
        private Label lblStock;
        private TextBox txtStock;
        private Button btnCrear;
    }
}