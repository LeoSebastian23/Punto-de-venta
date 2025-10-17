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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblName_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 41);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(57, 105);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(139, 97);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 27);
            txtCodigo.TabIndex = 3;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(57, 163);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(126, 20);
            lblPrecioCompra.TabIndex = 4;
            lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(189, 152);
            txtPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(284, 27);
            txtPrecioCompra.TabIndex = 5;
            // 
            // lblMargenGanancia
            // 
            lblMargenGanancia.AutoSize = true;
            lblMargenGanancia.Location = new Point(57, 217);
            lblMargenGanancia.Name = "lblMargenGanancia";
            lblMargenGanancia.Size = new Size(145, 20);
            lblMargenGanancia.TabIndex = 6;
            lblMargenGanancia.Text = "Margen de ganancia";
            // 
            // txtMargenGanancia
            // 
            txtMargenGanancia.Location = new Point(213, 209);
            txtMargenGanancia.Margin = new Padding(3, 4, 3, 4);
            txtMargenGanancia.Name = "txtMargenGanancia";
            txtMargenGanancia.Size = new Size(279, 27);
            txtMargenGanancia.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(57, 271);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(111, 20);
            lblPrecioVenta.TabIndex = 8;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 263);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 9;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(57, 320);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(127, 312);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(143, 27);
            txtStock.TabIndex = 11;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(183, 383);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(192, 63);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label1;
    }
}