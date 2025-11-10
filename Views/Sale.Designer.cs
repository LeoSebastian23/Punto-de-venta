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
            txtBuscador = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lblVentastitulo2 = new Label();
            lblTotal1 = new Label();
            btnCancelar1 = new Button();
            btnConfirmar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(3, 80);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(783, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.ForeColor = SystemColors.WindowFrame;
            txtBuscador.Location = new Point(418, 51);
            txtBuscador.Margin = new Padding(4, 3, 4, 3);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(311, 23);
            txtBuscador.TabIndex = 10;
            txtBuscador.Text = "Buscar producto";
            txtBuscador.TextChanged += textBox2_TextChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.FillWeight = 3.82643127F;
            Column2.HeaderText = "Código";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 3.82643127F;
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 61;
            // 
            // Column4
            // 
            Column4.FillWeight = 3.82643127F;
            Column4.HeaderText = "Precio";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stock";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.FillWeight = 3.82643127F;
            Column6.HeaderText = "Subtotal";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 30;
            // 
            // lblVentastitulo2
            // 
            lblVentastitulo2.AutoSize = true;
            lblVentastitulo2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVentastitulo2.Location = new Point(327, 21);
            lblVentastitulo2.Name = "lblVentastitulo2";
            lblVentastitulo2.Size = new Size(84, 32);
            lblVentastitulo2.TabIndex = 11;
            lblVentastitulo2.Text = "Ventas";
            // 
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal1.Location = new Point(617, 386);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(77, 30);
            lblTotal1.TabIndex = 12;
            lblTotal1.Text = "TOTAL:";
            lblTotal1.Click += lblTotal1_Click;
            // 
            // btnCancelar1
            // 
            btnCancelar1.BackColor = Color.Red;
            btnCancelar1.Location = new Point(84, 416);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(199, 35);
            btnCancelar1.TabIndex = 13;
            btnCancelar1.Text = "CANCELAR";
            btnCancelar1.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar2
            // 
            btnConfirmar2.BackColor = Color.Lime;
            btnConfirmar2.Location = new Point(394, 416);
            btnConfirmar2.Name = "btnConfirmar2";
            btnConfirmar2.Size = new Size(199, 35);
            btnConfirmar2.TabIndex = 14;
            btnConfirmar2.Text = "CONFIRMAR";
            btnConfirmar2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 493);
            Controls.Add(btnConfirmar2);
            Controls.Add(btnCancelar1);
            Controls.Add(lblTotal1);
            Controls.Add(lblVentastitulo2);
            Controls.Add(txtBuscador);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscador;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label lblVentastitulo2;
        private Label lblTotal1;
        private Button btnCancelar1;
        private Button btnConfirmar2;
    }
}

