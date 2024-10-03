using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Double Değişkenler


            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine(" ---- Elma Birim Fiyatı:" + applePrice + " ₺ ");
            //Console.WriteLine(" ---- Portakal Birim Fiyatı:" + orangePrice + " ₺ ");
            //Console.WriteLine(" ---- Çilek Birim Fiyatı:" + strawberryPrice + " ₺ ");
            //Console.WriteLine(" ---- Patates Birim Fiyatı:" + patatoPrice + " ₺ ");
            //Console.WriteLine(" ---- Domates Birim Fiyatı:" + tomatoPrice + " ₺ ");

            //Console.WriteLine() ;
            //Console.WriteLine() ;

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.584;
            //strawberryGram = 2.587;
            //patatoGram = 8.750;
            //tomatoGram = 3.250;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: ELMA -" + " Birim Fiyatı: " + applePrice + " ₺ " + "- Gramaj: " + appleGram + " gr " + " Toplam Tutar: " + appleTotalPrice + " ₺ ");
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Portakal -" + " Birim Fiyatı: " + orangePrice + " ₺ " + "- Gramaj: " + orangeGram + " gr " + " Toplam Tutar: " + orangeTotalPrice + " ₺ ");
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Çilek -" + " Birim Fiyatı: " + strawberryPrice + " ₺ " + " - Gramaj: " + strawberryGram + " gr " + " Toplam Tutar: " + strawberryTotalPrice + " ₺ ");
            //Console.WriteLine();


            //Console.WriteLine("Alınan Ürün: Patates -" + " Birim Fiyatı: "+ patatoPrice + " ₺ " + "- Gramaj: " + patatoGram + " gr " + " Toplam Tutar: " + patatoTotalPrice + " ₺ ");
            //Console.WriteLine();


            //Console.WriteLine("Alınan Ürün: Domates -" + " Birim Fiyatı: " + tomatoPrice + " ₺ " + "- Gramaj: " + tomatoGram + " gr " + "  Toplam Tutar: " + tomatoTotalPrice + " ₺ ");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " ₺ ");







            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF.....
            //TOPLANTI SAAT 20:00`DE kısaca karakterler alfebeye göre şifreleniyor.
            // "" değil shift+2 ye basarak '' tek tırnak kullanılacak.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcunun Yaşadığı Semt: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcunun Yaşadığı Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcunun Kimlik Numarası: ");
            //passengerIdNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge + " " + passengerIdNumber);





            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adetini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar adetini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye adetini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız tv adetini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount* shoesPrice + computerCount* computerPrice + chairCount* chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz gereken tutar: " + totalPrice + "TL");









            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. sınav notunu gir: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu gir: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu gir: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaman: " + result);



            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion



            Console.Read();

        }
    }
}
