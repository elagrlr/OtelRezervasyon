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
    public partial class FrmRapor : Form
    {
        private List<OdaRezervasyon> odaRezervasyonlari;
        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<OdaRezervasyon> odaRezervasyonlari) : this()
        {
            this.odaRezervasyonlari = odaRezervasyonlari;
        }

        /// <summary>
        /// Girilen tarihe göre arama yapan event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();

            int sayac = 1;

            foreach (OdaRezervasyon item in odaRezervasyonlari)
            {
                DateTime dt = Convert.ToDateTime(mstTarih.Text);
                if (item.GirisTarihi == dt || item.CikisTarihi == dt)
                {
                    KayitlariListele(item, odaRezervasyonlari, sayac);
                }
            }
        }

        /// <summary>
        /// Tüm kayıtları listeleyen event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListele_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
            int sayac = 1;
            foreach (OdaRezervasyon item in odaRezervasyonlari)
            {
                KayitlariListele(item, odaRezervasyonlari, sayac);
            }
        }

        /// <summary>
        /// Girilen tarih aralığına göre arama yapan event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarihAraligiAra_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
            int sayac = 1;
            foreach (OdaRezervasyon item in odaRezervasyonlari)
            {
                DateTime dt = Convert.ToDateTime(mstTarihAraligi1.Text);
                DateTime dt2 = Convert.ToDateTime(mstTarihAraligi2.Text);

                if (item.GirisTarihi >= dt || item.CikisTarihi <= dt2)
                {
                    KayitlariListele(item, odaRezervasyonlari, sayac);
                }
            }
        }

        /// <summary>
        /// Girilen isme göre arama yapan event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIsimAra_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
            string arananKelime = txtArananIsim.Text.ToLower();
            int sayac = 1;
            foreach (OdaRezervasyon item in odaRezervasyonlari)
            {
                if (item.Musteri.AdSoyad.ToLower().Contains(arananKelime))
                {
                    KayitlariListele(item, odaRezervasyonlari, sayac);
                    continue;
                }
            }
            if (lstRapor.Items.Count == 0)
            {
                MessageBox.Show("Aradığınız isimde bir müşteri bulunamadı.");
            }
        }

        /// <summary>
        /// Listview'in içini dolduran event
        /// </summary>
        /// <param name="item"></param>
        /// <param name="odaRezervasyonlari"></param>
        /// <param name="sayac"></param>
        private void KayitlariListele(OdaRezervasyon item, List<OdaRezervasyon> odaRezervasyonlari, int sayac)
        {
            ListViewItem li = new ListViewItem();

            li.Text = (sayac++).ToString();
            li.SubItems.Add(item.Oda.Numarasi.ToString());
            li.SubItems.Add(item.Oda.YatakSayisi.ToString());
            li.SubItems.Add(item.Musteri.AdSoyad);
            li.SubItems.Add(item.Musteri.TC);
            li.SubItems.Add(item.GirisTarihi.ToString());
            li.SubItems.Add(item.CikisTarihi.ToString());

            li.Tag = item;
            lstRapor.Items.Add(li);
        }
    }
}
