using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.UI.Common
{
    public class OrtakFonksiyonlar
    {
      
        public void OdaDurumuBelirle(Button tiklanilanButon, int durum)// Bos = 1 REnk sari,        Dolu = 2 renk kırmızı,        Temizlik = 3 renk mavi
        {
          
            switch (durum)
            {
                case 1:
                    tiklanilanButon.BackColor = Color.Yellow;
                    break;
                case 2:
                    tiklanilanButon.BackColor = Color.Red;
                    break;
                case 3:
                    tiklanilanButon.BackColor = Color.Blue;
                    break;
            }
        } 
        
    }
}
