namespace Punto_de_venta.Views
{
    partial class User
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
            lblUsuario = new Label();
            textBox1 = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(220, 152);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(200, 224);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.Location = new Point(307, 221);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(250, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = SystemColors.ActiveCaption;
            btnAcceder.BackgroundImageLayout = ImageLayout.None;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = SystemColors.ActiveCaptionText;
            btnAcceder.Location = new Point(307, 299);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(133, 41);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 65);
            label1.TabIndex = 5;
            label1.Text = "Olivia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 74);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 6;
            label2.Text = "Perfumería y Limpieza";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(textBox1);
            Controls.Add(lblUsuario);
            Name = "User";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox textBox1;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btnAcceder;
        private Label label1;
        private Label label2;
    }
}