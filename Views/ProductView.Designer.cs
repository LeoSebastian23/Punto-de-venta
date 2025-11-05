namespace Punto_de_venta.Views
{
    partial class ProductView
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
            LbeltxtName = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            LbeltxtCode = new Label();
            label6 = new Label();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnCancelar = new Button();
            btnGuardar = new Button();
            comboSupplier = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 7);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 4;
            label1.Text = "Crear Producto";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LbeltxtName
            // 
            LbeltxtName.AutoSize = true;
            LbeltxtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbeltxtName.Location = new Point(153, 98);
            LbeltxtName.Name = "LbeltxtName";
            LbeltxtName.Size = new Size(68, 21);
            LbeltxtName.TabIndex = 5;
            LbeltxtName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(248, 95);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 29);
            txtName.TabIndex = 6;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(248, 149);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(265, 29);
            txtCode.TabIndex = 8;
            // 
            // LbeltxtCode
            // 
            LbeltxtCode.AutoSize = true;
            LbeltxtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbeltxtCode.Location = new Point(159, 149);
            LbeltxtCode.Name = "LbeltxtCode";
            LbeltxtCode.Size = new Size(60, 21);
            LbeltxtCode.TabIndex = 7;
            LbeltxtCode.Text = "Código";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(513, 95);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(136, 212);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 15;
            label7.Text = "Proovedor";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(180, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 36);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Location = new Point(343, 279);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 36);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboSupplier
            // 
            comboSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(248, 214);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(265, 29);
            comboSupplier.TabIndex = 19;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(comboSupplier);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCode);
            Controls.Add(LbeltxtCode);
            Controls.Add(txtName);
            Controls.Add(LbeltxtName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductView";
            Text = "ProductView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label LbeltxtName;
        private TextBox txtName;
        private TextBox txtCode;
        private Label LbeltxtCode;
        private Label label6;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox comboSupplier;
    }
}