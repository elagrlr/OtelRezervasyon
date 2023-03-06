using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.UI.Common
{
    public class OrtakFonksiyonlar
    {
        /// <summary>
        /// Giris-cikis tarihleri dogru mu (Giris tarihi cikis tarihinden önce secilmis mi) kontrol eden fornksiyon
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool TarihKarsilastir(string s1, string s2)
        {
            DateTime dt1 = Convert.ToDateTime(s1);
            DateTime dt2 = Convert.ToDateTime(s2);
            if (dt1 <= dt2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Girilen textin bod olup olmadigini kontrol eden fonksiyon
        /// </summary>
        /// <param name="texts"></param>
        /// <returns></returns>
        public bool BosMu(params string[] texts)
        {
            foreach (var item in texts)
            {
                //boş ise girer
                if (string.IsNullOrWhiteSpace(item) || item.Length < 2)
                {
                    return false;
                }
            }
            //boş değil
            return true;
        }
        /// <summary>
        /// Text icinde sayi olup olmadigini kontrol eden fonksiyon
        /// </summary>
        /// <param name="texts"></param>
        /// <returns></returns>
        public bool SayiVarMi(params string[] texts)
        {
            foreach (var item in texts)
            {
                //sayi varsa girer
                if (item.Any(char.IsDigit))
                {
                    return false;
                }
            }
            //sayi yok
            return true;
        }
        /// <summary>
        /// Telefon numarasinin doğru formda girilip girilmedigini kontrol eden fonksiyon
        /// </summary>
        /// <param name="telefonNo"></param>
        /// <returns></returns>
        public bool TelefonNoKontrol(string telefonNo)
        {
            return Regex.IsMatch(telefonNo, @"^(5(\d{2})-(\d{3})-(\d{2})-(\d{2}))$", RegexOptions.IgnoreCase);
        }

        public bool TcKontrol(string tc)
        {
            #region uzun if

            if (tc.Length == 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
            {
                return true;
            }
            return false;
            #endregion

        }
        /// <summary>
        ///  Odanın durumuna gore butonların renklerini duzenleme fonksiyonu
        /// </summary>
        /// <param name="tiklanilanButon"></param>
        /// <param name="durum"></param>
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
        /// <summary>
        /// Musteri bilgileri alindiktan sonra form elemanlarini temizleme fonksiyonu
        /// </summary>
        /// <param name="txtAdSoyad"></param>
        /// <param name="txtTC"></param>
        /// <param name="mstDogumTarihi"></param>
        /// <param name="mstTel"></param>
        /// <param name="mstGirisTarihi"></param>
        /// <param name="mstCikisTarihi"></param>
        public void Temizle(TextBox txtAdSoyad, TextBox txtTC, MaskedTextBox mstDogumTarihi, MaskedTextBox mstTel, MaskedTextBox mstGirisTarihi, MaskedTextBox mstCikisTarihi)
        {
            txtAdSoyad.Clear();
            txtTC.Clear();
            mstDogumTarihi.Clear(); 
            mstTel.Clear();
            mstGirisTarihi.Clear();
            mstCikisTarihi.Clear();
        }
    }
}
