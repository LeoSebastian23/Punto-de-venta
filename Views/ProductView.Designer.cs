namespace Punto_de_venta.Views
{
    partial class ProductView
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
            btnAdd_Click = new Button();
            button2 = new Button();
            refresh = new Button();
            dataGridViewProducts = new DataGridView();
            label1 = new Label();
            LbeltxtName = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            LbeltxtCode = new Label();
            txtPurchasePrice = new TextBox();
            LbeltxtPurchasePrice = new Label();
            txtSalePrice = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtSupplierId = new TextBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // btnAdd_Click
            // 
            btnAdd_Click.Location = new Point(12, 220);
            btnAdd_Click.Name = "btnAdd_Click";
            btnAdd_Click.Size = new Size(94, 29);
            btnAdd_Click.TabIndex = 0;
            btnAdd_Click.Text = "Agregar ";
            btnAdd_Click.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(562, 220);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDelete_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(678, 220);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 2;
            refresh.Text = "Actualizar lista";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += btnRefresh_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 255);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(760, 183);
            dataGridViewProducts.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 4;
            label1.Text = "Menu de Productos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LbeltxtName
            // 
            LbeltxtName.AutoSize = true;
            LbeltxtName.Location = new Point(12, 120);
            LbeltxtName.Name = "LbeltxtName";
            LbeltxtName.Size = new Size(64, 20);
            LbeltxtName.TabIndex = 5;
            LbeltxtName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(112, 177);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 8;
            // 
            // LbeltxtCode
            // 
            LbeltxtCode.AutoSize = true;
            LbeltxtCode.Location = new Point(12, 177);
            LbeltxtCode.Name = "LbeltxtCode";
            LbeltxtCode.Size = new Size(58, 20);
            LbeltxtCode.TabIndex = 7;
            LbeltxtCode.Text = "Codigo";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(406, 120);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 10;
            // 
            // LbeltxtPurchasePrice
            // 
            LbeltxtPurchasePrice.AutoSize = true;
            LbeltxtPurchasePrice.ForeColor = SystemColors.ControlText;
            LbeltxtPurchasePrice.Location = new Point(274, 123);
            LbeltxtPurchasePrice.Name = "LbeltxtPurchasePrice";
            LbeltxtPurchasePrice.Size = new Size(126, 20);
            LbeltxtPurchasePrice.TabIndex = 9;
            LbeltxtPurchasePrice.Text = "Precio de compra";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(406, 177);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(125, 27);
            txtSalePrice.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 177);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio de venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(647, 120);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(586, 127);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 13;
            label6.Text = "Stock";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(647, 177);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(125, 27);
            txtSupplierId.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(562, 177);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 15;
            label7.Text = "Proovedor";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSupplierId);
            Controls.Add(label7);
            Controls.Add(txtStock);
            Controls.Add(label6);
            Controls.Add(txtSalePrice);
            Controls.Add(label5);
            Controls.Add(txtPurchasePrice);
            Controls.Add(LbeltxtPurchasePrice);
            Controls.Add(txtCode);
            Controls.Add(LbeltxtCode);
            Controls.Add(txtName);
            Controls.Add(LbeltxtName);
            Controls.Add(label1);
            Controls.Add(dataGridViewProducts);
            Controls.Add(refresh);
            Controls.Add(button2);
            Controls.Add(btnAdd_Click);
            Name = "ProductView";
            Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd_Click;
        private Button button2;
        private Button refresh;
        private DataGridView dataGridViewProducts;
        private Label label1;
        private Label LbeltxtName;
        private TextBox txtName;
        private TextBox txtCode;
        private Label LbeltxtCode;
        private TextBox txtPurchasePrice;
        private Label LbeltxtPurchasePrice;
        private TextBox txtSalePrice;
        private Label label5;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtSupplierId;
        private Label label7;
        private OpenFileDialog openFileDialog1;
    }
}