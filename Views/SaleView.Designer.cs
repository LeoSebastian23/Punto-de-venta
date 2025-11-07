namespace punto_venta
{
    partial class SaleView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblTotal = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            productoToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            proovedoresToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem1 = new ToolStripMenuItem();
            verComprasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            crearToolStripMenuItem2 = new ToolStripMenuItem();
            txtBuscador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Código1 = new DataGridViewTextBoxColumn();
            Nombre2 = new DataGridViewTextBoxColumn();
            Cantidad3 = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Subtotal5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código1, Nombre2, Cantidad3, Stock, Subtotal5 });
            dataGridView1.Location = new Point(14, 90);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(887, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(756, 430);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 13);
            lblTotal.TabIndex = 5;
            lblTotal.Text = ".........";
            lblTotal.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(649, 417);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(71, 33);
            textBox1.TabIndex = 6;
            textBox1.Text = "TOTAL:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { productoToolStripMenuItem, proovedoresToolStripMenuItem, usuariosToolStripMenuItem, usuariosToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(418, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.BackColor = Color.LightSlateGray;
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, modificarToolStripMenuItem });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(73, 20);
            productoToolStripMenuItem.Text = "Productos";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(180, 22);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // proovedoresToolStripMenuItem
            // 
            proovedoresToolStripMenuItem.BackColor = Color.SlateGray;
            proovedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem1 });
            proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            proovedoresToolStripMenuItem.Size = new Size(85, 20);
            proovedoresToolStripMenuItem.Text = "Proovedores";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(125, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(125, 22);
            modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.SlateGray;
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem1, verComprasToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(67, 20);
            usuariosToolStripMenuItem.Text = "Compras";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(141, 22);
            crearToolStripMenuItem1.Text = "Crear";
            // 
            // verComprasToolStripMenuItem
            // 
            verComprasToolStripMenuItem.Name = "verComprasToolStripMenuItem";
            verComprasToolStripMenuItem.Size = new Size(141, 22);
            verComprasToolStripMenuItem.Text = "Ver Compras";
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.BackColor = Color.SlateGray;
            usuariosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem2 });
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(64, 20);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // crearToolStripMenuItem2
            // 
            crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            crearToolStripMenuItem2.Size = new Size(102, 22);
            crearToolStripMenuItem2.Text = "Crear";
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.BackColor = SystemColors.MenuBar;
            txtBuscador.ForeColor = SystemColors.MenuText;
            txtBuscador.Location = new Point(80, 45);
            txtBuscador.Margin = new Padding(4, 3, 4, 3);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(685, 23);
            txtBuscador.TabIndex = 10;
            txtBuscador.Text = "Buscar producto";
            txtBuscador.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 428);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 11;
            label1.Text = "Usuario:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 428);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "__________";
            // 
            // Código1
            // 
            Código1.HeaderText = "Código";
            Código1.Name = "Código1";
            Código1.ReadOnly = true;
            // 
            // Nombre2
            // 
            Nombre2.HeaderText = "Nombre";
            Nombre2.Name = "Nombre2";
            Nombre2.ReadOnly = true;
            // 
            // Cantidad3
            // 
            Cantidad3.HeaderText = "Cantidad";
            Cantidad3.Name = "Cantidad3";
            Cantidad3.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Subtotal5
            // 
            Subtotal5.HeaderText = "Subtotal";
            Subtotal5.Name = "Subtotal5";
            Subtotal5.ReadOnly = true;
            // 
            // SaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 519);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(textBox1);
            Controls.Add(lblTotal);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SaleView";
            Text = "Venta";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proovedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem verComprasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem crearToolStripMenuItem2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Código1;
        private DataGridViewTextBoxColumn Nombre2;
        private DataGridViewTextBoxColumn Cantidad3;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Subtotal5;
    }
}

