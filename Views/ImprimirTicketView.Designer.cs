namespace Punto_de_venta.Views
{
    partial class ImprimirTicketView
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Desea imprimir ticket?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 72);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 1;
            label2.Text = "SI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(43, 102);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Presione Enter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 72);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 3;
            label4.Text = "NO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 102);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Presione ESC";
            // 
            // ImprimirTicketView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 151);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ImprimirTicketView";
            Text = "ImprimirTicketView";
            KeyDown += ImprimirTicketView_KeyDown;
            KeyPress += ImprimirTicketView_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}