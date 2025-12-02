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
            txtEdit = new TextBox();
            btnCancelar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 15);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(90, 50);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 23);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Location = new Point(268, 33);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 36);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lvItems
            // 
            lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvItems.Location = new Point(69, 88);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(491, 335);
            lvItems.TabIndex = 3;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.SelectedIndexChanged += lvItems_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmar.BackColor = Color.Green;
            btnConfirmar.Location = new Point(69, 444);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 35);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar venta";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(465, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 35);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(15, 18);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 52);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(278, 4);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(90, 23);
            txtEdit.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(246, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(415, 12);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 10;
            button1.Text = "Ventas del día";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(415, 50);
            button2.Name = "button2";
            button2.Size = new Size(136, 32);
            button2.TabIndex = 11;
            button2.Text = "Ventas de la semana";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormVentaTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 496);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(txtEdit);
            Controls.Add(lblCantidad);
            Controls.Add(lblCodigo);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(lvItems);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVentaTest";
            Text = "Test de Ventas";
            Load += FormVentaTest_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtEditor;
        private TextBox txtEdit;
        private Button btnCancelar;
        private Button button1;
        private Button button2;
    }
}
