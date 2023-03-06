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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1054, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekstra Hizmetler";
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
            this.cmbOdalar.Location = new System.Drawing.Point(163, 161);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(280, 24);
            this.cmbOdalar.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(449, 161);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(145, 27);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.lstSonuc.Location = new System.Drawing.Point(29, 241);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(903, 152);
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
            // columnHeader10
            // 
            this.columnHeader10.Text = "Toplam Tutar";
            this.columnHeader10.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Numarası Seçin";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(449, 415);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(145, 23);
            this.btnOdemeYap.TabIndex = 6;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam Fatura Tutarı :";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(318, 418);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(10, 16);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = " ";
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 713);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.flEkstra);
            this.Controls.Add(this.btnHesapla);
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
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListView lstSonuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTutar;
    }
}