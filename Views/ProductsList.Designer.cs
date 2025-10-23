namespace Punto_de_venta.Views
{
    partial class ProductsList
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            Código = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioCosto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nombre, PrecioCosto, PrecioVenta, Stock });
            dataGridView1.Location = new Point(39, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 300);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Buscar producto";
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            Código.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            PrecioCosto.HeaderText = "Precio de costo";
            PrecioCosto.Name = "PrecioCosto";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio de Venta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "ProductsList";
            Text = "ProductsList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCosto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
    }
}