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
    public partial class FrmOdaDurum : Form
    {
        private List<OdaRezervasyon> odaRezervasyons;

        public FrmOdaDurum()
        {
            InitializeComponent();
        }

        public FrmOdaDurum(List<OdaRezervasyon> odaRezervasyons)
        {
            this.odaRezervasyons = odaRezervasyons;
        }
    }
}
