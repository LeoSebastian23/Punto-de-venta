namespace Punto_de_venta.Views
{
    partial class BuysListView
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
            dgvBuysList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuysList).BeginInit();
            SuspendLayout();
            // 
            // dgvBuysList
            // 
            dgvBuysList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuysList.Location = new Point(19, 36);
            dgvBuysList.Name = "dgvBuysList";
            dgvBuysList.Size = new Size(756, 293);
            dgvBuysList.TabIndex = 0;
            // 
            // BuysListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBuysList);
            Name = "BuysListView";
            Text = "BuysListView";
            Load += BuysListView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuysList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuysList;
    }
}