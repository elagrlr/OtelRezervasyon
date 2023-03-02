using OtelRezervasyon.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OtelRezervasyon.UI
{
    public partial class FrmRezervasyonGiris : Form
    {
        public FrmRezervasyonGiris()
        {
            InitializeComponent();
        }

        public FrmRezervasyonGiris(List<OdaRezervasyon> odaRezervasyons)
        {
            this.odaRezervasyons = odaRezervasyons;
        }
        List<TextBox> textBoxes= new List<TextBox>();
        Button tiklanilanButon = null;
        public List<OdaRezervasyon> odaRezervasyonlari = new List<OdaRezervasyon>();
        OrtakFonksiyonlar ort = new OrtakFonksiyonlar();
        private List<OdaRezervasyon> odaRezervasyons;

        private void FrmRezervasyonGiris_Load(object sender, EventArgs e)
        {

            Button btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.Yellow;
            btnKral.Width = 400;
            btnKral.Height = 50;
            btnKral.Tag = new OdaRezervasyon()
            {
                Oda = new Oda()
                {
                    Fiyat = 1000,
                    Numarasi = 400,
                    OdaDurumu = (int)OdaDurumu.Bos,
                    YatakSayisi = 1
                },
                Musteri = new Musteri()
            }; ;
            btnKral.Click += Btn_Click;
            flKat4.Controls.Add(btnKral);

            int sayac = 99;
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 50,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = (int)OdaDurumu.Bos,
                        YatakSayisi = 1
                    },
                    Musteri = new Musteri()
                };

                btn.Click += Btn_Click;
                flKat1.Controls.Add(btn);

            }
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 100,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = (int)OdaDurumu.Bos,
                        YatakSayisi = 2
                    },
                    Musteri = new Musteri()
                };

                btn.Click += Btn_Click;
                flKat2.Controls.Add(btn);
            }
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 150,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = (int)OdaDurumu.Bos,
                        YatakSayisi = 3
                    },
                    Musteri = new Musteri()
                };

                btn.Click += Btn_Click;
                flKat3.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanilanButon = sender as Button;
            OdaRezervasyon rezervasyon = tiklanilanButon.Tag as OdaRezervasyon;
            //MessageBox.Show(tiklanilanButon.Text + " Tıklandı " + rezervasyon.Oda.OdaDurumu);


        }

        private void Temizle(TextBox t1, TextBox t2, MaskedTextBox t3, MaskedTextBox t4)
        {
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            OdaRezervasyon odarez = new OdaRezervasyon();
            odarez = tiklanilanButon.Tag as OdaRezervasyon;

            for (byte i=0;i<odarez.Oda.YatakSayisi;i++)
            {
                if (odarez.Oda.OdaDurumu == (int)OdaDurumu.Bos)
                {
                    //rez al yatak sayısıını da kontrol et
                    odarez.Musteri = new Musteri()
                    {
                        AdSoyad = txtAdSoyad.Text,
                        DogumTarihi = mstDogumTarihi.Text,
                        Tel = mstTel.Text,
                        TC = txtTC.Text
                    };
                    odarez.GirisTarihi = Convert.ToDateTime(mstGirisTarihi.Text);
                    
                    odaRezervasyonlari.Add(odarez);
                    this.Tag = odaRezervasyonlari;
                    MessageBox.Show("{0}. kişi kaydedildi",(i+1).ToString());
                 
                    Temizle(txtAdSoyad, txtTC, mstDogumTarihi, mstTel);
                    continue;
                }
                else
                {
                    //oda dolu 
                    MessageBox.Show("Oda Dolu");
                }
            }
            odarez.Oda.OdaDurumu = (int)OdaDurumu.Dolu;
            ort.OdaDurumuBelirle(tiklanilanButon, odarez.Oda.OdaDurumu);
        }

        
    }
}
/*
 for (byte i=0;i<rezervasyon.Oda.YatakSayisi;i++)
            { 
Label lbl = new Label();
lbl.Text = "Adı Soyadı";
txtAdSoyad = new TextBox();
Label lbl2 = new Label();
lbl2.Text = "Tc Kimlik No";
txtTC = new TextBox();
Label lbl3 = new Label();
lbl3.Text = "Telefon";
txtTel = new TextBox();
Label lbl4 = new Label();
lbl4.Text = "Doğum Tarihi";
txtDogumTarihi = new TextBox();
flKisi.Controls.Add(lbl);
flKisi.Controls.Add(txtAdSoyad);
flKisi.Controls.Add(lbl2);
flKisi.Controls.Add(txtTC);
flKisi.Controls.Add(lbl3);
flKisi.Controls.Add(txtTel);
flKisi.Controls.Add(lbl4);
flKisi.Controls.Add(txtDogumTarihi);
Temizle(txtTC, txtTel, txtAdSoyad, txtDogumTarihi);
                 
            }
 */
