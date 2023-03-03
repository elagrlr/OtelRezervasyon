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

        List<TextBox> textBoxes = new List<TextBox>();
        Button tiklanilanButon = null;
        public List<OdaRezervasyon> odaRezervasyonlari = new List<OdaRezervasyon>();
        OrtakFonksiyonlar ort = new OrtakFonksiyonlar();
        private List<OdaRezervasyon> odaRezervasyons;
        OdaRezervasyon odarez = new OdaRezervasyon();
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
                    YatakSayisi = 5
                },
                Musteri = new Musteri()
            };
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
            //validasyon kontrol
            if (ort.BosMu(txtAdSoyad.Text, txtTC.Text, mstTel.Text, mstDogumTarihi.Text, mstGirisTarihi.Text, mstCikisTarihi.Text) && ort.TcKontrol(txtTC.Text) && ort.SayiVarMi(txtAdSoyad.Text) && ort.TarihKarsilastir(mstGirisTarihi.Text, mstCikisTarihi.Text))
            {
                odarez = tiklanilanButon.Tag as OdaRezervasyon;

                //oda bos mu kontrol et
                if (odarez.Oda.OdaDurumu == (int)OdaDurumu.Bos)
                {

                    odarez.Musteri = new Musteri()
                    {
                        AdSoyad = txtAdSoyad.Text,
                        DogumTarihi = mstDogumTarihi.Text,
                        Tel = mstTel.Text,
                        TC = txtTC.Text
                    };

                    odarez.KisiSayisi = Convert.ToByte(nmKisi.Value);
                    odarez.GirisTarihi = Convert.ToDateTime(mstGirisTarihi.Text);
                    odarez.CikisTarihi = Convert.ToDateTime(mstCikisTarihi.Text);

                    //odanın yatak sayısı müşterinin isteğini karşılıyor mu kontrol et
                    if (odarez.KisiSayisi <= odarez.Oda.YatakSayisi)
                    {
                        odarez.Oda.OdaDurumu = (int)OdaDurumu.Dolu;
                        ort.OdaDurumuBelirle(tiklanilanButon, odarez.Oda.OdaDurumu);

                        odaRezervasyonlari.Add(odarez);

                    }
                    else
                    {
                        MessageBox.Show("Odanın kişi sayısı isteğe uygun değil.");
                    }


                    this.Tag = odaRezervasyonlari;

                }
                else
                {
                    //oda dolu 
                    MessageBox.Show("Oda Dolu");
                }
                Temizle(txtAdSoyad, txtTC, mstDogumTarihi, mstTel);

            }
            else
            {
                MessageBox.Show("Eksik/Hatalı girilen bilgiler var. Lütfen bilgileri kontrol edin.");
            }



        }
        //odayı temizliğe al
        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            if (tiklanilanButon.BackColor == Color.Red)
            {
                MessageBox.Show("Oda doluyken temizlik hizmeti istenemez.");
            }
            else
            {
                ort.OdaDurumuBelirle(tiklanilanButon, 3);
            }

        }
    }
}
