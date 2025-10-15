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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(47, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(50, 102);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(145, 100);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(250, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(175, 177);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(133, 41);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(textBox1);
            Controls.Add(lblUsuario);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox textBox1;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btnAcceder;
    }
}