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

namespace OtelRezervasyon.UI
{
    public partial class FrmCikis : Form
    {
        private List<OdaRezervasyon> odaRezervasyonlari;
        OrtakFonksiyonlar ort = new OrtakFonksiyonlar();

        public FrmCikis()
        {
            InitializeComponent();
        }

        public FrmCikis(List<OdaRezervasyon> odaRezervasyonlari) : this()
        {
            this.odaRezervasyonlari = odaRezervasyonlari;
        }

        List<OdaRezervasyon> doluOdalar = new List<OdaRezervasyon>();
        private void FrmCikis_Load(object sender, EventArgs e)
        {
            foreach (var item in odaRezervasyonlari)
            {
                if (item.Oda.OdaDurumu == 2)
                {
                    doluOdalar.Add(item);
                }
            }
            cmbOdalar.DataSource = doluOdalar;

            EkHizmetleriEkle();
        }

        public int KalinacakGunSayisi(DateTime GirisTarihi, DateTime CikisTarihi)
        {
            return (GirisTarihi - CikisTarihi).Days;
        }
        double toplam = 0;
        double hizmetToplam = 0;
        double araToplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (OdaRezervasyon item in odaRezervasyonlari)
            {
                if (cmbOdalar.SelectedValue.ToString() == item.Oda.Numarasi.ToString())
                {

                    int kalinanGunSayisi = KalinacakGunSayisi(item.CikisTarihi, item.GirisTarihi);

                    item.EkstraHizmetler = EkstraHesapla();
                    hizmetToplam = hizmetler.Sum(a => a.HizmetFiyati);

                    araToplam = ((kalinanGunSayisi * item.Oda.Fiyat));
                    toplam = araToplam + hizmetToplam;

                    //todo: listte ödeme bilgilerini de listele
                    KayitlariListele(item, odaRezervasyonlari);

                    item.Oda.OdaDurumu = 1;
                    lblTutar.Text = toplam.ToString() + " TL";
                }
            }
        }
        List<Hizmet> hizmetler = new List<Hizmet>();
        private List<Hizmet> EkstraHesapla()
        {
            foreach (CheckBox item in flEkstra.Controls)
            {
                if (item.Checked)
                {
                    hizmetler.Add((Hizmet)item.Tag);
                }
            }
            return hizmetler;
        }

        string ekHizmetToplam;
        void EkHizmetleriEkle()
        {
            flEkstra.Controls.Add(new CheckBox() { Text = "Kola", Tag = new Hizmet() { HizmetAdi = "Kola", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Maden Suyu", Tag = new Hizmet() { HizmetAdi = "Maden Suyu", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Su", Tag = new Hizmet() { HizmetAdi = "Su", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Bira", Tag = new Hizmet() { HizmetAdi = "Bira", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Şarap", Tag = new Hizmet() { HizmetAdi = "Şarap", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Enerji İçeceği", Tag = new Hizmet() { HizmetAdi = "Enerji İçeceği", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Ütü", Tag = new Hizmet() { HizmetAdi = "Ütü", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Masaj", Tag = new Hizmet() { HizmetAdi = "Masaj", HizmetFiyati = 10 } });
            flEkstra.Controls.Add(new CheckBox() { Text = "Sauna", Tag = new Hizmet() { HizmetAdi = "Sauna", HizmetFiyati = 10 } });



        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Oda Ücreti :" + araToplam + " TL\n Ekstar Hizmet Ücretleri: " + hizmetToplam + " TL\n Toplam Ücret: " + toplam + " TL", "Ödeme Ekranı", MessageBoxButtons.OK);
            toplam = 0;
            lblTutar.Text = toplam.ToString() + " TL";
        }

        private void KayitlariListele(OdaRezervasyon item, List<OdaRezervasyon> odaRezervasyonlari)
        {
            ListViewItem li = new ListViewItem();
            li.SubItems.Add(item.Oda.Numarasi.ToString());
            li.SubItems.Add(item.Oda.YatakSayisi.ToString());
            li.SubItems.Add(item.Musteri.AdSoyad);
            li.SubItems.Add(item.Musteri.TC);
            li.SubItems.Add(item.GirisTarihi.ToString());
            li.SubItems.Add(item.CikisTarihi.ToString());

            li.Tag = item;
            lstSonuc.Items.Add(li);
        }
    }
}
