namespace Punto_de_venta.Views
{
    partial class BuysListView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBuysList;

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
            this.dgvBuysList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuysList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuysList
            // 
            this.dgvBuysList.AllowUserToAddRows = false;
            this.dgvBuysList.AllowUserToDeleteRows = false;
            this.dgvBuysList.AllowUserToResizeRows = false;
            this.dgvBuysList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuysList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuysList.Location = new System.Drawing.Point(20, 25);
            this.dgvBuysList.MultiSelect = false;
            this.dgvBuysList.Name = "dgvBuysList";
            this.dgvBuysList.ReadOnly = true;
            this.dgvBuysList.RowHeadersVisible = false;
            this.dgvBuysList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuysList.Size = new System.Drawing.Size(760, 380);
            this.dgvBuysList.TabIndex = 0;

            // 🔹 Agregar columnas
            this.dgvBuysList.Columns.Add("Id", "ID");
            this.dgvBuysList.Columns.Add("Supplier", "Proveedor");
            this.dgvBuysList.Columns.Add("Invoice", "Factura");
            this.dgvBuysList.Columns.Add("Date", "Fecha");
            this.dgvBuysList.Columns.Add("Total", "Total");

            // 
            // BuysListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBuysList);
            this.Name = "BuysListView";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.BuysListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuysList)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

