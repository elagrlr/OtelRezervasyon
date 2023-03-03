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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(List<OdaRezervasyon> odaRezervasyonlari)
        {
            this.odaRezervasyonlari = odaRezervasyonlari;
        }
        private List<OdaRezervasyon> odaRezervasyonlari; 
        FrmRezervasyonGiris frmRezervasyonGiris = new FrmRezervasyonGiris();
        FrmCikis frmCikis;
        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRezervasyonGiris.MdiParent = this;
            frmRezervasyonGiris.Show();
        }

        private void tumRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapor frmRapor = new FrmRapor(frmRezervasyonGiris.Tag as List<OdaRezervasyon>);
            frmRapor.MdiParent = this;
            frmRapor.Show();
        }

        private void odemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCikis frmCikis = new FrmCikis(frmRezervasyonGiris.Tag as List<OdaRezervasyon>);
            frmCikis.MdiParent = this;
            frmCikis.Show();
        }

         
    }
}
