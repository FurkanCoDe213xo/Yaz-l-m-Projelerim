using System;

namespace Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* <veri tipi> <değişken ismi> = veri (değer)
            int tam sayı demektir.*/
            int Bay = 12; int YM;

            YM = 12000;

            Console.WriteLine("2024 Yıllık Maaşım " + YM);
            Console.WriteLine("2024 Aylık Maaşım " + YM / Bay);

            YM = 24000; //Değiştirirken veri tipi kullanılmaz.

            Console.WriteLine("2025 Yıllık Maaşım : " + YM);
            Console.WriteLine("2025 Aylık Maaşım : " + YM / 12);
            // KODLAR YUKARIDAN AŞAĞIYA OKUNUR
        }
    }
}
