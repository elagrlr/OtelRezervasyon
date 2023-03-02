namespace OtelRezervasyon.UI
{
    partial class FrmCikis
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
            this.label1 = new System.Windows.Forms.Label();
            this.flEkstra = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Numarası Seçin";
            // 
            // flEkstra
            // 
            this.flEkstra.Location = new System.Drawing.Point(1057, 105);
            this.flEkstra.Name = "flEkstra";
            this.flEkstra.Size = new System.Drawing.Size(320, 558);
            this.flEkstra.TabIndex = 3;
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(163, 44);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(280, 24);
            this.cmbOdalar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstSonuc.HideSelection = false;
            this.lstSonuc.Location = new System.Drawing.Point(12, 197);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(920, 144);
            this.lstSonuc.TabIndex = 5;
            this.lstSonuc.UseCompatibleStateImageBehavior = false;
            this.lstSonuc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda No";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad Soyad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tc Kimlik No";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giriş Tarihi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Çıkış Tarihi";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kalınan Gün";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ek Hizmet Toplam";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ara Toplam";
            this.columnHeader9.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çıkış Tarihi Seçin";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(163, 105);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(124, 22);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Toplam";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No";
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 713);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.flEkstra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCikis";
            this.Text = "FrmCikis";
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flEkstra;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstSonuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}