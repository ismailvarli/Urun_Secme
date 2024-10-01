using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__kursu
{
    internal static class Urunler
    {
        static string[] GirilenUrunler = { "1-Ayakkabı", "2-Pantolon", "3-Saat" };
        static double[] UrunFiyatlari = { 1000, 500, 1500 };

        internal static void UrunleriListele()
        {
            for (int i = 0; i < GirilenUrunler.Length; i++)
            {
                Console.WriteLine($"Ürün: {GirilenUrunler[i]}  Fiyat: {UrunFiyatlari[i]} TL");
            }
        }

        internal static void Urunsecme()
        {
            Console.WriteLine("1. Ürünü Seçiniz (1, 2 veya 3):");
            int urun1 = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("2. Ürünü Seçiniz (1, 2 veya 3):");
            int urun2 = Convert.ToInt32(Console.ReadLine()) - 1;

            if (urun1 >= 0 && urun1 < GirilenUrunler.Length && urun2 >= 0 && urun2 < GirilenUrunler.Length)
            {
                double fiyat1 = UrunFiyatlari[urun1];
                double fiyat2 = UrunFiyatlari[urun2];

                if (fiyat1 > fiyat2)
                {
                    fiyat1 *= 0.70; 
                    Console.WriteLine($"Birinci Ürünün İndirimli Fiyatı: {fiyat1}");
                    Console.WriteLine($"Toplam: {fiyat1 + fiyat2} TL");
                }
                else
                {
                    fiyat2 *= 0.70; 
                    Console.WriteLine($"İkinci Ürünün İndirimli Fiyatı: {fiyat2}");
                    Console.WriteLine($"\nToplam: {fiyat1 + fiyat2} TL");
                }
             
            }
            else
            {
                Console.WriteLine("\nGeçersiz seçim. Lütfen 1, 2 veya 3'ü seçin.");
            }
        }

        internal static void UcuncuUrun()
        {
            Console.WriteLine("\nÜçüncü Bir Ürün Seçmek İster miydiniz? (1-Evet/2-Hayır)");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                double fiyat3 = UrunFiyatlari[2] * 0.50; 
                Console.WriteLine($"\nÜçüncü Ürüne Uygulanan İndirimli Fiyat: {fiyat3} TL");
            }
            else if (secim == "2")
            {
                Console.WriteLine("İyi Günler.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Geçerli Bir Seçim Yapınız!!!");
            }
        }
    }
}
            
        

    



    

