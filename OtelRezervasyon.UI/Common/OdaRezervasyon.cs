using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.UI.Common
{
    public class OdaRezervasyon
    {
        public Oda Oda { get; internal set; }
        public Musteri Musteri { get; internal set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public List<Hizmet> EkstraHizmetler { get; set; }
        public byte KisiSayisi { get; set; }
        public override string ToString()
        {
            return ((Oda.Numarasi).ToString());
        }
    }
}
