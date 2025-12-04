namespace Punto_de_venta.Views
{
    partial class FormVentaDetalleView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lvItems = new System.Windows.Forms.ListView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lvItems
            // 
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(12, 60);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(560, 290);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;

            // columnas
            this.lvItems.Columns.Add("Producto", 200);
            this.lvItems.Columns.Add("Cantidad", 80);
            this.lvItems.Columns.Add("P. Unitario", 100);
            this.lvItems.Columns.Add("Subtotal", 120);

            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(450, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";

            // 
            // FormVentaDetalleView
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lvItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FormVentaDetalleView";
            this.Text = "Detalle de la Venta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
