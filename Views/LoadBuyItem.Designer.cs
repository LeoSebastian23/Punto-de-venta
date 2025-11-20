namespace Punto_de_venta.Views
{
    partial class LoadBuyItem
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
            lblProduct = new Label();
            txtProduct = new TextBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblCost = new Label();
            numCost = new NumericUpDown();
            lblSalePrice = new Label();
            numSalePrice = new NumericUpDown();
            lblMargin = new Label();
            numMargin = new NumericUpDown();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(20, 20);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(72, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Producto:";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(150, 20);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(200, 27);
            txtProduct.TabIndex = 1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 60);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(150, 53);
            numQuantity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 27);
            numQuantity.TabIndex = 3;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(20, 100);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(50, 20);
            lblCost.TabIndex = 4;
            lblCost.Text = "Costo:";
            // 
            // numCost
            // 
            numCost.DecimalPlaces = 2;
            numCost.Location = new Point(150, 93);
            numCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(120, 27);
            numCost.TabIndex = 5;
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Location = new Point(20, 140);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(114, 20);
            lblSalePrice.TabIndex = 6;
            lblSalePrice.Text = "Precio de venta:";
            // 
            // numSalePrice
            // 
            numSalePrice.DecimalPlaces = 2;
            numSalePrice.Location = new Point(150, 138);
            numSalePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSalePrice.Name = "numSalePrice";
            numSalePrice.Size = new Size(120, 27);
            numSalePrice.TabIndex = 7;
            // 
            // lblMargin
            // 
            lblMargin.AutoSize = true;
            lblMargin.Location = new Point(20, 180);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(86, 20);
            lblMargin.TabIndex = 8;
            lblMargin.Text = "Margen (%)";
            // 
            // numMargin
            // 
            numMargin.DecimalPlaces = 2;
            numMargin.Location = new Point(150, 178);
            numMargin.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numMargin.Name = "numMargin";
            numMargin.Size = new Size(120, 27);
            numMargin.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(60, 230);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 30);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(180, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            // 
            // LoadBuyItem
            // 
            ClientSize = new Size(389, 290);
            Controls.Add(lblProduct);
            Controls.Add(txtProduct);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(lblCost);
            Controls.Add(numCost);
            Controls.Add(lblSalePrice);
            Controls.Add(numSalePrice);
            Controls.Add(lblMargin);
            Controls.Add(numMargin);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Name = "LoadBuyItem";
            Text = "Cargar Ítem";
            Load += LoadBuyItem_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.NumericUpDown numSalePrice;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.NumericUpDown numMargin;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

