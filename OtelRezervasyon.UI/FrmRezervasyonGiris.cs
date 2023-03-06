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
        Button tiklanilanButon = null;

        OrtakFonksiyonlar ortakIslemler = new OrtakFonksiyonlar();
        OdaRezervasyon rezerveEdilecekOda = new OdaRezervasyon();

        public List<OdaRezervasyon> odaRezervasyonlari = new List<OdaRezervasyon>();
        private List<OdaRezervasyon> odaRezervasyons;

        public FrmRezervasyonGiris()
        {
            InitializeComponent();
        }

        public FrmRezervasyonGiris(List<OdaRezervasyon> odaRezervasyons)
        {
            this.odaRezervasyons = odaRezervasyons;
        }
        /// <summary>
        /// Form yuklendiginde  calisacak olan event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRezervasyonGiris_Load(object sender, EventArgs e)
        {
            BirinciKatOdalariOlustur(99);

            IkinciKatOdalariOlustur(199);

            UcuncuKatOdalariOlustur(299);

            KralDairesiOlustur(399);
        }
        /// <summary>
        /// Kral dairesi icin buton oluşturma eventi
        /// </summary>
        /// <param name="sayac"></param>
        private void KralDairesiOlustur(int v)
        {
            Button btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.Yellow;
            btnKral.Width = 300;
            btnKral.Height = 55;
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
        }
        /// <summary>
        /// Ucuncu katta bulunan odalar icin buton oluşturma fonksiyonu
        /// </summary>
        /// <param name="sayac"></param>
        private void UcuncuKatOdalariOlustur(int sayac)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Width = 55;
                btn.Height = 55;
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
        /// <summary>
        /// Ikinci katta bulunan odalar icin buton oluşturma fonksiyonu
        /// </summary>
        /// <param name="sayac"></param>
        private void IkinciKatOdalariOlustur(int sayac)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Width = 55;
                btn.Height = 55;
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
        }
       /// <summary>
       /// Birinci katta bulunan odalar icin buton oluşturma fonksiyonu
       /// </summary>
       /// <param name="sayac"></param>
        private void BirinciKatOdalariOlustur(int sayac)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Width = 55;
                btn.Height = 55;
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
        }

        /// <summary>
        /// Oda numarasını tutmak için olusturulan click eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanilanButon = sender as Button;
            OdaRezervasyon rezervasyon = tiklanilanButon.Tag as OdaRezervasyon;
        }

        /// <summary>
        /// Rezervasyon listesine rezervasyon ekleyen event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //validasyon kontrol
            if (ortakIslemler.BosMu(txtAdSoyad.Text, txtTC.Text, mstTel.Text, mstDogumTarihi.Text, mstGirisTarihi.Text, mstCikisTarihi.Text) && ortakIslemler.TcKontrol(txtTC.Text) && ortakIslemler.SayiVarMi(txtAdSoyad.Text) && ortakIslemler.TarihKarsilastir(mstGirisTarihi.Text, mstCikisTarihi.Text))
            {
                rezerveEdilecekOda = tiklanilanButon.Tag as OdaRezervasyon;

                // Odanın bos olup olmadığını kontrol et
                if (rezerveEdilecekOda.Oda.OdaDurumu == (int)OdaDurumu.Bos)
                {
                    rezerveEdilecekOda.Musteri = new Musteri()
                    {
                        AdSoyad = txtAdSoyad.Text,
                        DogumTarihi = mstDogumTarihi.Text,
                        Tel = mstTel.Text,
                        TC = txtTC.Text
                    };

                    rezerveEdilecekOda.KisiSayisi = Convert.ToByte(nmKisi.Value);
                    rezerveEdilecekOda.GirisTarihi = Convert.ToDateTime(mstGirisTarihi.Text);
                    rezerveEdilecekOda.CikisTarihi = Convert.ToDateTime(mstCikisTarihi.Text);

                    // Odanın yatak sayısı müşterinin isteğini karşılıyor mu kontrol et
                    if (rezerveEdilecekOda.KisiSayisi <= rezerveEdilecekOda.Oda.YatakSayisi)
                    {
                        rezerveEdilecekOda.Oda.OdaDurumu = (int)OdaDurumu.Dolu;
                        ortakIslemler.OdaDurumuBelirle(tiklanilanButon, rezerveEdilecekOda.Oda.OdaDurumu);

                        odaRezervasyonlari.Add(rezerveEdilecekOda);
                    }
                    else
                    {
                        MessageBox.Show("Odanın kişi sayısı isteğe uygun değil.");
                    }
                    this.Tag = odaRezervasyonlari;

                }
                else
                {
                    MessageBox.Show("Oda Dolu");
                }
                ortakIslemler.Temizle(txtAdSoyad, txtTC, mstDogumTarihi, mstTel, mstGirisTarihi, mstCikisTarihi);

            }
            else
            {
                MessageBox.Show("Eksik/Hatalı girilen bilgiler var. Lütfen bilgileri kontrol edin.");
            }
        }

        /// <summary>
        /// Odayi temizlik duruuna ceken event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            if (tiklanilanButon.BackColor == Color.Red)
            {
                MessageBox.Show("Oda doluyken temizlik hizmeti istenemez.");
            }
            else
            { 
                ortakIslemler.OdaDurumuBelirle(tiklanilanButon, 3);
            }
        }

    }
}
