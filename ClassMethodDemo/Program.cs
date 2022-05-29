namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123456";
            musteri1.Ad = "İbrahim";
            musteri1.Soyad = "Seyman";
            musteri1.Telefon = "05551067813";
            musteri1.HesapNo = "1111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "123457";
            musteri2.Ad = "Esma";
            musteri2.Soyad = "Seyman";
            musteri2.Telefon = "05073653773";
            musteri2.HesapNo = "2222";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "123458";
            musteri3.Ad = "Ömer";
            musteri3.Soyad = "Seyman";
            musteri3.Telefon = "05362745033";
            musteri3.HesapNo = "3333";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("\n");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("\n");

            musteriManager.Sil(musteri3);
        }
    }
}