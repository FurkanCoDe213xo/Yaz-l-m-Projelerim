namespace Sayısal_Veri_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
A. Tam Sayı Veri Tipleri

byte: 8-bit işaretsiz tam sayılar. Aralık: 0 ile 255.
byte yas = 25;

sbyte: 8-bit işaretli tam sayılar. Aralık: -128 ile 127.
sbyte negatifSayi = -50;

short: 16-bit işaretli tam sayılar. Aralık: -32,768 ile 32,767.
short hiz = 1200;

ushort: 16-bit işaretsiz tam sayılar. Aralık: 0 ile 65,535.
ushort stok = 5000;

int: 32-bit işaretli tam sayılar. Aralık: -2,147,483,648 ile 2,147,483,647.
int sayi = 10000;

uint: 32-bit işaretsiz tam sayılar. Aralık: 0 ile 4,294,967,295.
uint uzaklik = 200000;

long: 64-bit işaretli tam sayılar. Aralık: -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807.
long populasyon = 7800000000;

ulong: 64-bit işaretsiz tam sayılar. Aralık: 0 ile 18,446,744,073,709,551,615.
ulong mesafe = 10000000000;


B. Ondalık Sayı Veri Tipleri

float: 32-bit kayan nokta sayılar. Aralık: ±1.5 x 10^−45 ile ±3.4 x 10^38. Tek duyarlıklı (single precision) veri türüdür.
float pi = 3.14f;

double: 64-bit kayan nokta sayılar. Aralık: ±5.0 × 10^−324 ile ±1.7 × 10^308. Çift duyarlıklı (double precision) veri türüdür.
double e = 2.718281828;

decimal: 128-bit ondalıklı sayılar. Aralık: ±1.0 × 10^−28 ile ±7.9228 × 10^28. Yüksek hassasiyetli para ve finansal hesaplamalar için kullanılır.
decimal para = 100.50m;
            */ 
            byte age = 25;      // Byte sınır = 0 ile 255 arası
            short speed = -120;  // Short sınır sayısı -32.768 ile 32.767  arası
            int number = 1992999334;
            long population = 1900000000000L;  // ESKİ VERSİYONLARDA SAYININ SONUNA "L" KONUR!

            float Pi = 3.14f;         // Float ta sayının sonuna "f" konur!
            double e = 2.343554;
            decimal money = 100.50m;   // Decimalde sayının sonuna "m" konur!
            Console.WriteLine(population);
        }
    }
}
