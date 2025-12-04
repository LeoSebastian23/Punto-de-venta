namespace Punto_de_venta.Views
{
    partial class FormVentasListView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvVentas;

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
            this.lvVentas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvVentas
            // 
            this.lvVentas.FullRowSelect = true;
            this.lvVentas.GridLines = true;
            this.lvVentas.HideSelection = false;
            this.lvVentas.Location = new System.Drawing.Point(12, 12);
            this.lvVentas.MultiSelect = false;
            this.lvVentas.Name = "lvVentas";
            this.lvVentas.Size = new System.Drawing.Size(560, 337);
            this.lvVentas.TabIndex = 0;
            this.lvVentas.UseCompatibleStateImageBehavior = false;
            this.lvVentas.View = System.Windows.Forms.View.Details;

            // Columnas:
            this.lvVentas.Columns.Add("Fecha", 180);
            this.lvVentas.Columns.Add("Ítems", 80);
            this.lvVentas.Columns.Add("Total", 120);
            // 
            // FormVentasListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentasListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Ventas";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
