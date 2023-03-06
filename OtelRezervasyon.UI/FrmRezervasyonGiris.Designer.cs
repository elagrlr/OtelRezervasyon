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
            this.components = new System.ComponentModel.Container();
            this.flKat1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpKisiBilgisi = new System.Windows.Forms.GroupBox();
            this.nmKisi = new System.Windows.Forms.NumericUpDown();
            this.mstCikisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mstGirisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mstDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mstTel = new System.Windows.Forms.MaskedTextBox();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.btnTemizlik = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grpKisiBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flKat1
            // 
            this.flKat1.Location = new System.Drawing.Point(30, 26);
            this.flKat1.Name = "flKat1";
            this.flKat1.Size = new System.Drawing.Size(341, 120);
            this.flKat1.TabIndex = 0;
            // 
            // flKat2
            // 
            this.flKat2.Location = new System.Drawing.Point(30, 152);
            this.flKat2.Name = "flKat2";
            this.flKat2.Size = new System.Drawing.Size(341, 120);
            this.flKat2.TabIndex = 0;
            // 
            // flKat3
            // 
            this.flKat3.Location = new System.Drawing.Point(30, 278);
            this.flKat3.Name = "flKat3";
            this.flKat3.Size = new System.Drawing.Size(341, 120);
            this.flKat3.TabIndex = 0;
            // 
            // flKat4
            // 
            this.flKat4.Location = new System.Drawing.Point(30, 404);
            this.flKat4.Name = "flKat4";
            this.flKat4.Size = new System.Drawing.Size(341, 120);
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
            this.groupBox1.Size = new System.Drawing.Size(403, 546);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otelin Genel Durumu";
            // 
            // grpKisiBilgisi
            // 
            this.grpKisiBilgisi.Controls.Add(this.nmKisi);
            this.grpKisiBilgisi.Controls.Add(this.mstCikisTarihi);
            this.grpKisiBilgisi.Controls.Add(this.mstGirisTarihi);
            this.grpKisiBilgisi.Controls.Add(this.mstDogumTarihi);
            this.grpKisiBilgisi.Controls.Add(this.mstTel);
            this.grpKisiBilgisi.Controls.Add(this.lblKisiSayisi);
            this.grpKisiBilgisi.Controls.Add(this.lblAdSoyad);
            this.grpKisiBilgisi.Controls.Add(this.txtAdSoyad);
            this.grpKisiBilgisi.Controls.Add(this.btnEkle);
            this.grpKisiBilgisi.Controls.Add(this.lblTCKN);
            this.grpKisiBilgisi.Controls.Add(this.txtTC);
            this.grpKisiBilgisi.Controls.Add(this.lblTelefon);
            this.grpKisiBilgisi.Controls.Add(this.lblCikisTarihi);
            this.grpKisiBilgisi.Controls.Add(this.lblDogumTarihi);
            this.grpKisiBilgisi.Controls.Add(this.lblGirisTarihi);
            this.grpKisiBilgisi.Location = new System.Drawing.Point(421, 12);
            this.grpKisiBilgisi.Name = "grpKisiBilgisi";
            this.grpKisiBilgisi.Size = new System.Drawing.Size(516, 546);
            this.grpKisiBilgisi.TabIndex = 2;
            this.grpKisiBilgisi.TabStop = false;
            this.grpKisiBilgisi.Text = "Müşteri Bilgileri";
            // 
            // nmKisi
            // 
            this.nmKisi.Location = new System.Drawing.Point(212, 238);
            this.nmKisi.Name = "nmKisi";
            this.nmKisi.Size = new System.Drawing.Size(156, 27);
            this.nmKisi.TabIndex = 4;
            // 
            // mstCikisTarihi
            // 
            this.mstCikisTarihi.Location = new System.Drawing.Point(212, 306);
            this.mstCikisTarihi.Mask = "00/00/0000";
            this.mstCikisTarihi.Name = "mstCikisTarihi";
            this.mstCikisTarihi.Size = new System.Drawing.Size(156, 27);
            this.mstCikisTarihi.TabIndex = 3;
            this.mstCikisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mstGirisTarihi
            // 
            this.mstGirisTarihi.Location = new System.Drawing.Point(212, 273);
            this.mstGirisTarihi.Mask = "00/00/0000";
            this.mstGirisTarihi.Name = "mstGirisTarihi";
            this.mstGirisTarihi.Size = new System.Drawing.Size(156, 27);
            this.mstGirisTarihi.TabIndex = 3;
            this.mstGirisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mstDogumTarihi
            // 
            this.mstDogumTarihi.Location = new System.Drawing.Point(212, 205);
            this.mstDogumTarihi.Mask = "00/00/0000";
            this.mstDogumTarihi.Name = "mstDogumTarihi";
            this.mstDogumTarihi.Size = new System.Drawing.Size(156, 27);
            this.mstDogumTarihi.TabIndex = 3;
            this.mstDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mstTel
            // 
            this.mstTel.Location = new System.Drawing.Point(212, 172);
            this.mstTel.Mask = "(999) 000-0000";
            this.mstTel.Name = "mstTel";
            this.mstTel.Size = new System.Drawing.Size(156, 27);
            this.mstTel.TabIndex = 3;
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(101, 240);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(87, 20);
            this.lblKisiSayisi.TabIndex = 2;
            this.lblKisiSayisi.Text = "Kişi Sayısı";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(101, 96);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(88, 20);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Adı Soyadı";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(212, 93);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(156, 27);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(212, 357);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(101, 135);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(104, 20);
            this.lblTCKN.TabIndex = 2;
            this.lblTCKN.Text = "Tc Kimlik No";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(212, 135);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(156, 27);
            this.txtTC.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(101, 175);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(64, 20);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Location = new System.Drawing.Point(101, 313);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(93, 20);
            this.lblCikisTarihi.TabIndex = 2;
            this.lblCikisTarihi.Text = "Çıkış Tarihi";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(101, 212);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(110, 20);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Location = new System.Drawing.Point(101, 280);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(92, 20);
            this.lblGirisTarihi.TabIndex = 2;
            this.lblGirisTarihi.Text = "Giriş Tarihi";
            // 
            // btnTemizlik
            // 
            this.btnTemizlik.Location = new System.Drawing.Point(244, 564);
            this.btnTemizlik.Name = "btnTemizlik";
            this.btnTemizlik.Size = new System.Drawing.Size(171, 37);
            this.btnTemizlik.TabIndex = 3;
            this.btnTemizlik.Text = "Odayı Temizliğe Al";
            this.btnTemizlik.UseVisualStyleBackColor = true;
            this.btnTemizlik.Click += new System.EventHandler(this.btnTemizlik_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRezervasyonGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 745);
            this.Controls.Add(this.btnTemizlik);
            this.Controls.Add(this.grpKisiBilgisi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRezervasyonGiris";
            this.Text = "FrmRezervasyonGiris";
            this.Load += new System.EventHandler(this.FrmRezervasyonGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpKisiBilgisi.ResumeLayout(false);
            this.grpKisiBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flKat1;
        private System.Windows.Forms.FlowLayoutPanel flKat2;
        private System.Windows.Forms.FlowLayoutPanel flKat3;
        private System.Windows.Forms.FlowLayoutPanel flKat4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpKisiBilgisi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox mstDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mstTel;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.MaskedTextBox mstGirisTarihi;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.NumericUpDown nmKisi;
        private System.Windows.Forms.Button btnTemizlik;
        private System.Windows.Forms.MaskedTextBox mstCikisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}