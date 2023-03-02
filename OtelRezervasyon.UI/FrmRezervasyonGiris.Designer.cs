namespace OtelRezervasyon.UI
{
    partial class FrmRezervasyonGiris
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
            this.flKat1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mstGirisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mstDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mstTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flKisi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flKat1
            // 
            this.flKat1.Location = new System.Drawing.Point(20, 26);
            this.flKat1.Name = "flKat1";
            this.flKat1.Size = new System.Drawing.Size(450, 120);
            this.flKat1.TabIndex = 0;
            // 
            // flKat2
            // 
            this.flKat2.Location = new System.Drawing.Point(20, 152);
            this.flKat2.Name = "flKat2";
            this.flKat2.Size = new System.Drawing.Size(450, 120);
            this.flKat2.TabIndex = 0;
            // 
            // flKat3
            // 
            this.flKat3.Location = new System.Drawing.Point(20, 278);
            this.flKat3.Name = "flKat3";
            this.flKat3.Size = new System.Drawing.Size(450, 120);
            this.flKat3.TabIndex = 0;
            // 
            // flKat4
            // 
            this.flKat4.Location = new System.Drawing.Point(20, 404);
            this.flKat4.Name = "flKat4";
            this.flKat4.Size = new System.Drawing.Size(450, 120);
            this.flKat4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flKat1);
            this.groupBox1.Controls.Add(this.flKat4);
            this.groupBox1.Controls.Add(this.flKat2);
            this.groupBox1.Controls.Add(this.flKat3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 546);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otelin Genel Durumu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flKisi);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.mstGirisTarihi);
            this.groupBox2.Controls.Add(this.mstDogumTarihi);
            this.groupBox2.Controls.Add(this.mstTel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTC);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(540, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 601);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // mstGirisTarihi
            // 
            this.mstGirisTarihi.Location = new System.Drawing.Point(126, 285);
            this.mstGirisTarihi.Mask = "00/00/0000";
            this.mstGirisTarihi.Name = "mstGirisTarihi";
            this.mstGirisTarihi.Size = new System.Drawing.Size(156, 27);
            this.mstGirisTarihi.TabIndex = 3;
            this.mstGirisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mstDogumTarihi
            // 
            this.mstDogumTarihi.Location = new System.Drawing.Point(126, 252);
            this.mstDogumTarihi.Mask = "00/00/0000";
            this.mstDogumTarihi.Name = "mstDogumTarihi";
            this.mstDogumTarihi.Size = new System.Drawing.Size(156, 27);
            this.mstDogumTarihi.TabIndex = 3;
            this.mstDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mstTel
            // 
            this.mstTel.Location = new System.Drawing.Point(126, 219);
            this.mstTel.Mask = "(999) 000-0000";
            this.mstTel.Name = "mstTel";
            this.mstTel.Size = new System.Drawing.Size(156, 27);
            this.mstTel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Adı Soyadı";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(126, 140);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(156, 27);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(126, 357);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tc Kimlik No";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(126, 182);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(156, 27);
            this.txtTC.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doğum Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Giriş Tarihi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kişi Sayısı Seçin";
            // 
            // flKisi
            // 
            this.flKisi.Location = new System.Drawing.Point(288, 140);
            this.flKisi.Name = "flKisi";
            this.flKisi.Size = new System.Drawing.Size(221, 197);
            this.flKisi.TabIndex = 4;
            // 
            // FrmRezervasyonGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRezervasyonGiris";
            this.Text = "FrmRezervasyonGiris";
            this.Load += new System.EventHandler(this.FrmRezervasyonGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flKat1;
        private System.Windows.Forms.FlowLayoutPanel flKat2;
        private System.Windows.Forms.FlowLayoutPanel flKat3;
        private System.Windows.Forms.FlowLayoutPanel flKat4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox mstDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mstTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mstGirisTarihi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flKisi;
    }
}