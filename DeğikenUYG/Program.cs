using System;

// Basit bir giriş noktası ekledim — eğitim amaçlı konsol çıktısı.
class Program
{
    static void Main(string[] args)
    {
        /*
    C# Veri Tipleri

    Value Types: 
        Tam sayı:            byte, short, int, long
        Ondalıklı sayılar:   float, double, decimal
        Diğer Veri Tipleri:  char, boolean, struct

    Reference Types:
        String, Class, Array, Interface

*/

        int sayi = 200;
        decimal kdvOrani = 1.18m;
        char cinsiyet = 'K';
        string cinsiyet2 = "Kadın";
        string urunAdi = "Samsung S23";
        var satisDurumu = false;

        Console.WriteLine("Sayı: " + sayi);
        Console.WriteLine("KDV Oranı: " + kdvOrani);
        Console.WriteLine("Cinsiyet (char): " + cinsiyet);
        Console.WriteLine("Cinsiyet (string): " + cinsiyet2);
        Console.WriteLine("Ürün Adı: " + urunAdi);
        Console.WriteLine("Satış Durumu: " + satisDurumu);  

    }
}