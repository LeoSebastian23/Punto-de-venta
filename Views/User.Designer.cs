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
            textBox1 = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(33, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Introducir usuario";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(42, 170);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(200, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(74, 246);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(133, 29);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 373);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(textBox1);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox txtContraseña;
        private Button btnAcceder;
    }
}