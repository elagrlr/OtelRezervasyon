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
        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<OdaRezervasyon> odaRezervasyonlari):this()
        {
            this.odaRezervasyonlari = odaRezervasyonlari;
        }
        private List<OdaRezervasyon> odaRezervasyonlari;
        
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach(OdaRezervasyon item in odaRezervasyonlari)
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
}
