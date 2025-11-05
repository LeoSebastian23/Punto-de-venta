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
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dataGridViewProducts = new DataGridView();
            labelTitle = new Label();
            labelName = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            labelCode = new Label();
            txtPurchasePrice = new TextBox();
            labelPurchasePrice = new Label();
            txtSalePrice = new TextBox();
            labelSalePrice = new Label();
            txtStock = new TextBox();
            labelStock = new Label();
            labelSupplier = new Label();
            txtSupplierId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(562, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(678, 220);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Actualizar lista";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 255);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(760, 183);
            dataGridViewProducts.TabIndex = 3;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(188, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(421, 54);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "\U0001f9fa Gestión Productos";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 120);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Nombre";
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
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(12, 177);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(58, 20);
            labelCode.TabIndex = 7;
            labelCode.Text = "Código";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(406, 120);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 10;
            // 
            // labelPurchasePrice
            // 
            labelPurchasePrice.AutoSize = true;
            labelPurchasePrice.Location = new Point(274, 123);
            labelPurchasePrice.Name = "labelPurchasePrice";
            labelPurchasePrice.Size = new Size(126, 20);
            labelPurchasePrice.TabIndex = 9;
            labelPurchasePrice.Text = "Precio de compra";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(406, 177);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(125, 27);
            txtSalePrice.TabIndex = 12;
            // 
            // labelSalePrice
            // 
            labelSalePrice.AutoSize = true;
            labelSalePrice.Location = new Point(274, 177);
            labelSalePrice.Name = "labelSalePrice";
            labelSalePrice.Size = new Size(111, 20);
            labelSalePrice.TabIndex = 11;
            labelSalePrice.Text = "Precio de venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(647, 120);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 14;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(586, 127);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(45, 20);
            labelStock.TabIndex = 13;
            labelStock.Text = "Stock";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(562, 177);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(77, 20);
            labelSupplier.TabIndex = 15;
            labelSupplier.Text = "Proveedor";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(647, 177);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(125, 27);
            txtSupplierId.TabIndex = 16;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSupplierId);
            Controls.Add(labelSupplier);
            Controls.Add(txtStock);
            Controls.Add(labelStock);
            Controls.Add(txtSalePrice);
            Controls.Add(labelSalePrice);
            Controls.Add(txtPurchasePrice);
            Controls.Add(labelPurchasePrice);
            Controls.Add(txtCode);
            Controls.Add(labelCode);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "ProductView";
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dataGridViewProducts;
        private Label labelTitle;
        private Label labelName;
        private TextBox txtName;
        private TextBox txtCode;
        private Label labelCode;
        private TextBox txtPurchasePrice;
        private Label labelPurchasePrice;
        private TextBox txtSalePrice;
        private Label labelSalePrice;
        private TextBox txtStock;
        private Label labelStock;
        private Label labelSupplier;
        private TextBox txtSupplierId;
    }
}
