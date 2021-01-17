using System;

namespace _3_hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Methodlar var bu hafta... 


            Urun adidas = new Urun();
            adidas.urunAdi = "Adidas";
            adidas.urunFiyati = 150.45;
            adidas.urunAciklama = "Adidas Erkek Ayakkabı";

            Urun nike = new Urun();
            nike.urunAdi = "Nike";
            nike.urunFiyati = 120.23;
            nike.urunAciklama = "Nike Kadın Ayakkabısı 1. sınıf kalite";


            Urun[] urunler = new Urun[] {adidas,nike
                //Boş bir array bile oluşturacaksan , buraya boş bir süslü parantez açmak zorundasın . 
            };


            foreach (Urun urun in urunler)
            {
                //Urun = Tipi , nesne , urunler dizisi içinde dönecek.
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.urunAciklama);
                Console.WriteLine("**************");
            }
            //SepetManager nesnesinden oluşturduk şuan.
            SepetManager sepet = new SepetManager();
            //SepetManager tipindeki sepet nesnesinin ekle fonksiyonunu çağırdım.
            sepet.Ekle(adidas);
            sepet.Ekle(nike);

        }
    }
}
