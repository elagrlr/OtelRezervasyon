namespace OtelRezervasyon.UI
{
    partial class FrmRapor
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
            this.lstRapor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTarihAraligiAra = new System.Windows.Forms.Button();
            this.btnIsimAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mstTarih = new System.Windows.Forms.MaskedTextBox();
            this.mstTarihAraligi1 = new System.Windows.Forms.MaskedTextBox();
            this.mstTarihAraligi2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtArananIsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRapor
            // 
            this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstRapor.HideSelection = false;
            this.lstRapor.Location = new System.Drawing.Point(12, 260);
            this.lstRapor.Name = "lstRapor";
            this.lstRapor.Size = new System.Drawing.Size(1033, 383);
            this.lstRapor.TabIndex = 0;
            this.lstRapor.UseCompatibleStateImageBehavior = false;
            this.lstRapor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kayıt No";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda No";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yatak Sayısı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ad Soyad";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tc Kimlik No";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giriş Tarihi";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Çıkış Tarihi";
            this.columnHeader7.Width = 100;
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.Location = new System.Drawing.Point(291, 35);
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.Size = new System.Drawing.Size(75, 23);
            this.btnTarihAra.TabIndex = 1;
            this.btnTarihAra.Text = "Ara";
            this.btnTarihAra.UseVisualStyleBackColor = true;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarihe Göre Arama Yap";
            // 
            // btnTarihAraligiAra
            // 
            this.btnTarihAraligiAra.Location = new System.Drawing.Point(397, 37);
            this.btnTarihAraligiAra.Name = "btnTarihAraligiAra";
            this.btnTarihAraligiAra.Size = new System.Drawing.Size(75, 23);
            this.btnTarihAraligiAra.TabIndex = 1;
            this.btnTarihAraligiAra.Text = "Ara";
            this.btnTarihAraligiAra.UseVisualStyleBackColor = true;
            this.btnTarihAraligiAra.Click += new System.EventHandler(this.btnTarihAraligiAra_Click);
            // 
            // btnIsimAra
            // 
            this.btnIsimAra.Location = new System.Drawing.Point(345, 34);
            this.btnIsimAra.Name = "btnIsimAra";
            this.btnIsimAra.Size = new System.Drawing.Size(75, 23);
            this.btnIsimAra.TabIndex = 1;
            this.btnIsimAra.Text = "Ara";
            this.btnIsimAra.UseVisualStyleBackColor = true;
            this.btnIsimAra.Click += new System.EventHandler(this.btnIsimAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Yapmak İstediğiniz\r\n Günü Girin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mstTarih
            // 
            this.mstTarih.Location = new System.Drawing.Point(185, 35);
            this.mstTarih.Mask = "00/00/0000";
            this.mstTarih.Name = "mstTarih";
            this.mstTarih.Size = new System.Drawing.Size(100, 22);
            this.mstTarih.TabIndex = 4;
            this.mstTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mstTarihAraligi1
            // 
            this.mstTarihAraligi1.Location = new System.Drawing.Point(185, 38);
            this.mstTarihAraligi1.Mask = "00/00/0000";
            this.mstTarihAraligi1.Name = "mstTarihAraligi1";
            this.mstTarihAraligi1.Size = new System.Drawing.Size(100, 22);
            this.mstTarihAraligi1.TabIndex = 4;
            this.mstTarihAraligi1.ValidatingType = typeof(System.DateTime);
            // 
            // mstTarihAraligi2
            // 
            this.mstTarihAraligi2.Location = new System.Drawing.Point(291, 38);
            this.mstTarihAraligi2.Mask = "00/00/0000";
            this.mstTarihAraligi2.Name = "mstTarihAraligi2";
            this.mstTarihAraligi2.Size = new System.Drawing.Size(100, 22);
            this.mstTarihAraligi2.TabIndex = 4;
            this.mstTarihAraligi2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arama Yapmak İstediğiniz\r\n Gün Aralığını Girin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arama Yapmak İstediğiniz\r\n Günü Girin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTarihAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mstTarih);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTarihAraligiAra);
            this.groupBox2.Controls.Add(this.mstTarihAraligi2);
            this.groupBox2.Controls.Add(this.mstTarihAraligi1);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnIsimAra);
            this.groupBox3.Controls.Add(this.txtArananIsim);
            this.groupBox3.Location = new System.Drawing.Point(565, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // txtArananIsim
            // 
            this.txtArananIsim.Location = new System.Drawing.Point(165, 34);
            this.txtArananIsim.Name = "txtArananIsim";
            this.txtArananIsim.Size = new System.Drawing.Size(174, 22);
            this.txtArananIsim.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aramak İstediğiniz \r\nİsmi Girin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(561, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "İsme Göre Arama Yap";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnListele);
            this.groupBox4.Location = new System.Drawing.Point(565, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(170, 41);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tüm Kayıtları Lİsteleyin\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 655);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRapor);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstRapor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnTarihAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTarihAraligiAra;
        private System.Windows.Forms.Button btnIsimAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mstTarih;
        private System.Windows.Forms.MaskedTextBox mstTarihAraligi1;
        private System.Windows.Forms.MaskedTextBox mstTarihAraligi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArananIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
    }
}