using System;

namespace TurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 14;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();
            
            //1.Yöntem Parse
            string sayi1 = "2";
            string sayi2 = "5";
            int c = int.Parse(sayi1);
            int d = int.Parse(sayi2);
            Console.WriteLine(c + d);
            

            //int string dönüştürme
            int sayi1 = 8;
            int sayi2 = 10;
            string a = sayi1.ToString();
            string b = sayi2.ToString();
            Console.WriteLine(a + b);
            */
            //Kullanıcıdan yaşını alıp ekrana yazdırıp çıktı alma
            Console.WriteLine("Lütfen yaşınızı giriniz");
            string kullanici_yasi = Console.ReadLine();
            //int kullanici_yasiInt = int.Parse(kullanici_yasi);
            int kullanici_yasiInt = Convert.ToInt32(kullanici_yasi);
            Console.WriteLine(kullanici_yasiInt);
            
            
            
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            string sayi2 = Console.ReadLine();
            int sayi1Int = Convert.ToInt32(sayi1);
            int sayi2Int = Convert.ToInt32(sayi2);
            Console.WriteLine("İki sayının toplamı:" +(sayi1Int + sayi2Int));
            Console.ReadLine();
            
        }
    }
}
