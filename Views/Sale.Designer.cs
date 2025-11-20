namespace punto_venta
{
    partial class Form1
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
            Código1 = new DataGridViewTextBoxColumn();
            Nombre2 = new DataGridViewTextBoxColumn();
            Cantidad3 = new DataGridViewTextBoxColumn();
            Precio4 = new DataGridViewTextBoxColumn();
            Subtotal5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
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
            txtBuscador = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código1, Nombre2, Cantidad3, Precio4, Subtotal5 });
            dataGridView1.Location = new Point(16, 120);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(939, 409);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Código1
            // 
            Código1.HeaderText = "Código";
            Código1.MinimumWidth = 6;
            Código1.Name = "Código1";
            // 
            // Nombre2
            // 
            Nombre2.HeaderText = "Nombre";
            Nombre2.MinimumWidth = 6;
            Nombre2.Name = "Nombre2";
            Nombre2.ReadOnly = true;
            // 
            // Cantidad3
            // 
            Cantidad3.HeaderText = "Cantidad";
            Cantidad3.MinimumWidth = 6;
            Cantidad3.Name = "Cantidad3";
            Cantidad3.ReadOnly = true;
            // 
            // Precio4
            // 
            Precio4.HeaderText = "Precio";
            Precio4.MinimumWidth = 6;
            Precio4.Name = "Precio4";
            Precio4.ReadOnly = true;
            // 
            // Subtotal5
            // 
            Subtotal5.HeaderText = "Subtotal";
            Subtotal5.MinimumWidth = 6;
            Subtotal5.Name = "Subtotal5";
            Subtotal5.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(843, 543);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 5;
            label1.Text = ".........";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(787, 538);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(59, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "TOTAL:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productoToolStripMenuItem, proovedoresToolStripMenuItem, usuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(284, 30);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, modificarToolStripMenuItem });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(89, 24);
            productoToolStripMenuItem.Text = "Productos";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(156, 26);
            crearToolStripMenuItem.Text = "Crear";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(156, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // proovedoresToolStripMenuItem
            // 
            proovedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem1 });
            proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            proovedoresToolStripMenuItem.Size = new Size(106, 24);
            proovedoresToolStripMenuItem.Text = "Proovedores";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(156, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(156, 26);
            modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(127, 26);
            crearToolStripMenuItem1.Text = "Crear";
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.Location = new Point(92, 60);
            txtBuscador.Margin = new Padding(4, 5, 4, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(783, 27);
            txtBuscador.TabIndex = 10;
            txtBuscador.Text = "Buscar producto";
            txtBuscador.TextChanged += textBox2_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(txtBuscador);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Código1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal5;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

