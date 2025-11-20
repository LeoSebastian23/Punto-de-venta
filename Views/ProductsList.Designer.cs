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
            label1 = new Label();
            btnCrearProducto = new Button();
            dgvListaProductos = new DataGridView();
            txtBuscar = new TextBox();
            lstSugerencias = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 5;
            label1.Text = "Lista de Productos";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.BackColor = Color.LightSeaGreen;
            btnCrearProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearProducto.Location = new Point(107, 61);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(137, 37);
            btnCrearProducto.TabIndex = 6;
            btnCrearProducto.Text = "Crear producto";
            btnCrearProducto.UseVisualStyleBackColor = false;
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Location = new Point(12, 117);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.Size = new Size(776, 302);
            dgvListaProductos.TabIndex = 7;
            dgvListaProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = SystemColors.MenuText;
            txtBuscar.Location = new Point(483, 67);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(275, 27);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lstSugerencias
            // 
            lstSugerencias.FormattingEnabled = true;
            lstSugerencias.ItemHeight = 15;
            lstSugerencias.Location = new Point(483, 100);
            lstSugerencias.Name = "lstSugerencias";
            lstSugerencias.Size = new Size(275, 34);
            lstSugerencias.TabIndex = 9;
            lstSugerencias.Visible = false;
            lstSugerencias.Click += lstSugerencias_Click;
            lstSugerencias.SelectedIndexChanged += lstSugerencias_SelectedIndexChanged;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSugerencias);
            Controls.Add(txtBuscar);
            Controls.Add(dgvListaProductos);
            Controls.Add(btnCrearProducto);
            Controls.Add(label1);
            Name = "ProductsList";
            Text = "ProductsList";
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnCrearProducto;
        private DataGridView dgvListaProductos;
        private TextBox txtBuscar;
        private ListBox lstSugerencias;
    }
}