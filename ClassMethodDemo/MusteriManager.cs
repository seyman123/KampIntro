using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Bankamıza " + musteri.Ad + " " + musteri.Soyad + " kayıt edilmiştir");
        }
        public void Listele(Musteri musteri)
        { 
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Telefon No: " + musteri.Telefon + " Hesap No: " + musteri.HesapNo);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " bankamız kayıtlarından silinmiştir!");
        }
    }
}
