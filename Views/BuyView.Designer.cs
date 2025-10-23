namespace Punto_de_venta.Views
{
    partial class BuyView
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
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Compras";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad, PrecioUnitario, Subtotal });
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(587, 285);
            dataGridView1.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Buscar producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(452, 381);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 3;
            label2.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 393);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "------------";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(111, 388);
            button1.Name = "button1";
            button1.Size = new Size(97, 24);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(248, 387);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // BuyView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 431);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "BuyView";
            Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}