namespace Punto_de_venta.Views
{
    partial class FormVentaTest
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            lvItems = new ListView();
            btnConfirmar = new Button();
            lblTotal = new Label();
            lblCodigo = new Label();
            lblCantidad = new Label();
            btnCancelar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(103, 20);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(171, 27);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(103, 67);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(91, 27);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gray;
            btnAgregar.Location = new Point(297, 49);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 48);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lvItems
            // 
            lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvItems.Location = new Point(79, 117);
            lvItems.Margin = new Padding(3, 4, 3, 4);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(561, 445);
            lvItems.TabIndex = 3;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmar.BackColor = Color.Green;
            btnConfirmar.Location = new Point(79, 592);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(137, 47);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar venta";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(531, 592);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(105, 47);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(17, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(17, 69);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(281, 592);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 47);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(474, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 43);
            button1.TabIndex = 10;
            button1.Text = "Ventas del día";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnVentasDia_Click;
            // 
            // button2
            // 
            button2.Location = new Point(474, 67);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(155, 43);
            button2.TabIndex = 11;
            button2.Text = "Ventas del mes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnVentasMes_Click;
            // 
            // FormVentaTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 661);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(lblCantidad);
            Controls.Add(lblCodigo);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(lvItems);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormVentaTest";
            Text = "Test de Ventas";
            Load += FormVentaTest_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtEditor;
        private Button btnCancelar;
        private Button button1;
        private Button button2;
    }
}
