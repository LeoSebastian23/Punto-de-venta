namespace Punto_de_venta.Views
{
    partial class ProductView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            lblCode = new Label();
            lblBaseCost = new Label();
            lblSalePrice = new Label();
            lblMargin = new Label();
            lblStock = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            numBaseCost = new NumericUpDown();
            numSalePrice = new NumericUpDown();
            numMargin = new NumericUpDown();
            numStock = new NumericUpDown();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            lblCostobse = new Label();
            lblPrecioventa = new Label();
            lblPorcentaje = new Label();
            button1 = new Button();
            btnEliminarproducto = new Button();
            ((System.ComponentModel.ISupportInitialize)numBaseCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre:";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(20, 60);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(49, 15);
            lblCode.TabIndex = 1;
            lblCode.Text = "Código:";
            // 
            // lblBaseCost
            // 
            lblBaseCost.AutoSize = true;
            lblBaseCost.Location = new Point(20, 100);
            lblBaseCost.Name = "lblBaseCost";
            lblBaseCost.Size = new Size(68, 15);
            lblBaseCost.TabIndex = 2;
            lblBaseCost.Text = "Costo base:";
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Location = new Point(20, 140);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(91, 15);
            lblSalePrice.TabIndex = 3;
            lblSalePrice.Text = "Precio de venta:";
            // 
            // lblMargin
            // 
            lblMargin.AutoSize = true;
            lblMargin.Location = new Point(20, 182);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(72, 15);
            lblMargin.TabIndex = 4;
            lblMargin.Text = "Margen (%):";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 222);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 23);
            txtName.TabIndex = 6;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(140, 60);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(262, 23);
            txtCode.TabIndex = 7;
            // 
            // numBaseCost
            // 
            numBaseCost.DecimalPlaces = 2;
            numBaseCost.Font = new Font("Microsoft Sans Serif", 9F);
            numBaseCost.Location = new Point(140, 100);
            numBaseCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBaseCost.Name = "numBaseCost";
            numBaseCost.Size = new Size(120, 21);
            numBaseCost.TabIndex = 8;
            numBaseCost.ValueChanged += numBaseCost_ValueChanged;
            // 
            // numSalePrice
            // 
            numSalePrice.DecimalPlaces = 2;
            numSalePrice.Location = new Point(140, 140);
            numSalePrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numSalePrice.Name = "numSalePrice";
            numSalePrice.Size = new Size(120, 23);
            numSalePrice.TabIndex = 9;
            // 
            // numMargin
            // 
            numMargin.DecimalPlaces = 2;
            numMargin.Location = new Point(140, 182);
            numMargin.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numMargin.Name = "numMargin";
            numMargin.Size = new Size(120, 23);
            numMargin.TabIndex = 10;
            // 
            // numStock
            // 
            numStock.Location = new Point(140, 222);
            numStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SkyBlue;
            btnAdd.Location = new Point(121, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 43);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Agregar producto";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Location = new Point(20, 310);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(500, 250);
            dgvProducts.TabIndex = 13;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // lblCostobse
            // 
            lblCostobse.AutoSize = true;
            lblCostobse.Location = new Point(121, 103);
            lblCostobse.Name = "lblCostobse";
            lblCostobse.Size = new Size(13, 15);
            lblCostobse.TabIndex = 14;
            lblCostobse.Text = "$";
            // 
            // lblPrecioventa
            // 
            lblPrecioventa.AutoSize = true;
            lblPrecioventa.Location = new Point(121, 142);
            lblPrecioventa.Name = "lblPrecioventa";
            lblPrecioventa.Size = new Size(13, 15);
            lblPrecioventa.TabIndex = 15;
            lblPrecioventa.Text = "$";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(266, 184);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(17, 15);
            lblPorcentaje.TabIndex = 16;
            lblPorcentaje.Text = "%";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(266, 257);
            button1.Name = "button1";
            button1.Size = new Size(99, 43);
            button1.TabIndex = 17;
            button1.Text = "Modificar producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnEliminarproducto
            // 
            btnEliminarproducto.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarproducto.Location = new Point(421, 257);
            btnEliminarproducto.Name = "btnEliminarproducto";
            btnEliminarproducto.Size = new Size(99, 43);
            btnEliminarproducto.TabIndex = 18;
            btnEliminarproducto.Text = "Eliminar producto";
            btnEliminarproducto.UseVisualStyleBackColor = false;
            // 
            // ProductView
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(565, 580);
            Controls.Add(btnEliminarproducto);
            Controls.Add(button1);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblPrecioventa);
            Controls.Add(lblCostobse);
            Controls.Add(lblName);
            Controls.Add(lblCode);
            Controls.Add(lblBaseCost);
            Controls.Add(lblSalePrice);
            Controls.Add(lblMargin);
            Controls.Add(lblStock);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(numBaseCost);
            Controls.Add(numSalePrice);
            Controls.Add(numMargin);
            Controls.Add(numStock);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductView";
            Text = "Gestión de Productos";
            Load += ProductView_Load;
            ((System.ComponentModel.ISupportInitialize)numBaseCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.Label lblStock;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;

        private System.Windows.Forms.NumericUpDown numBaseCost;
        private System.Windows.Forms.NumericUpDown numSalePrice;
        private System.Windows.Forms.NumericUpDown numMargin;
        private System.Windows.Forms.NumericUpDown numStock;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private Label lblCostobse;
        private Label lblPrecioventa;
        private Label lblPorcentaje;
        private Button button1;
        private Button btnEliminarproducto;
    }
}


