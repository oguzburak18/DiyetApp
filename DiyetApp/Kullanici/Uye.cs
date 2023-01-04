using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Kullanici
{
    public class Uye
    {
        public int Id { get; set; }

        public string KullaniciAdi { get; set; }

        public string Ad { get; set; } 

        public string Soyad { get; set; } 

        public bool Cinsiyet { get; set; }

        public int Yas { get; set; }

        public string Email { get; set; } 

        public string Telefon { get; set; } 

        public string Sifre { get; set; } 

        public int Kilo { get; set; }

        public int Boy { get; set; }

        public string GizliYanit { get; set; } 

        public double HedefKalori { get; set; }

        public double HedefKaloriHesaplama()
        {
            if(Cinsiyet == true)
            {
                return 655 + 9.6 * Kilo + 1.8 * Boy + 4.7 * Yas;
            }
            else
            {
                return 660 + 13.7 * Kilo + 5 * Boy + 6.8 * Yas;
            }
        }
    }
}
