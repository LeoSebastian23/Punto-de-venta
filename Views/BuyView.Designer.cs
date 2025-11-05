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
            dgvCompra = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtBuscar = new TextBox();
            lstSugerencias = new ListBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboSupplier = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Cursor;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Compras";
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(25, 182);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.Size = new Size(864, 230);
            dgvCompra.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(687, 428);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 3;
            label2.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 436);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "------------";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(306, 436);
            button1.Name = "button1";
            button1.Size = new Size(97, 24);
            button1.TabIndex = 5;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(95, 435);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = SystemColors.WindowFrame;
            txtBuscar.Location = new Point(550, 75);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(339, 29);
            txtBuscar.TabIndex = 8;
            txtBuscar.Text = "Buscar producto";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lstSugerencias
            // 
            lstSugerencias.FormattingEnabled = true;
            lstSugerencias.ItemHeight = 15;
            lstSugerencias.Location = new Point(550, 108);
            lstSugerencias.Name = "lstSugerencias";
            lstSugerencias.Size = new Size(339, 64);
            lstSugerencias.TabIndex = 9;
            lstSugerencias.Click += lstSugerencias_Click;
            lstSugerencias.SelectedIndexChanged += lstSugerencias_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 78);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 10;
            label4.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 117);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 12;
            label5.Text = "Nro de factura";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(162, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 29);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(95, 148);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 14;
            label6.Text = "Fecha";
            // 
            // comboSupplier
            // 
            comboSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(162, 75);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(180, 29);
            comboSupplier.TabIndex = 15;
            comboSupplier.SelectedIndexChanged += comboSupplier_SelectedIndexChanged;
            // 
            // BuyView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 484);
            Controls.Add(comboSupplier);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstSugerencias);
            Controls.Add(txtBuscar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCompra);
            Controls.Add(label1);
            Name = "BuyView";
            Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCompra;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox txtBuscar;
        private ListBox lstSugerencias;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private ComboBox comboSupplier;
    }
}