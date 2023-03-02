namespace OtelRezervasyon.UI
{
    partial class FrmOdaDurum
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
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOdaDurum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(279, 74);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(162, 24);
            this.cmbOdalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Durumunu güncellemek istediğiniz\r\n odayı seçin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbOdaDurum
            // 
            this.cmbOdaDurum.FormattingEnabled = true;
            this.cmbOdaDurum.Location = new System.Drawing.Point(279, 152);
            this.cmbOdaDurum.Name = "cmbOdaDurum";
            this.cmbOdaDurum.Size = new System.Drawing.Size(162, 24);
            this.cmbOdaDurum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda durumunu seçin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmOdaDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOdaDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdalar);
            this.Name = "FrmOdaDurum";
            this.Text = "FRmOdaDurum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOdaDurum;
        private System.Windows.Forms.Label label2;
    }
}