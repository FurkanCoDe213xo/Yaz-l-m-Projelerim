//?    Uygulama 2
/*
* Bir öğrecinin 2 yazılı 1 sözlü notunu hesaplanan ortelamına göre not aralığına karşılık gelen not bilgisini if-else yapısı kullanarak ekrana yazdıran uygulamayı yapınız.
*/

Console.Write("1. Yazılı Notunu Giriniz: ");
double not1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2. Yazılı Notunu Giriniz: ");
double not2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Sözlü Notunu Giriniz: ");
double sozlu = Convert.ToDouble(Console.ReadLine());

var ortalama = (not1 + not2 + sozlu) / 3;
int Not;

if (ortalama > 0 && ortalama <= 25)
{
    Not = 0;
    Console.WriteLine("Notunuz: " + Not);
}
else if (ortalama >= 25 && ortalama <= 45)
{
    Not = 1;
    Console.WriteLine("Notunuz: " + Not);
}
else if (ortalama >= 45 && ortalama <= 55)
{
    Not = 2;
    Console.WriteLine("Notunuz: " + Not);
}
else if (ortalama >= 55 && ortalama <= 70)
{
    Not = 3;
    Console.WriteLine("Notunuz: " + Not);
}
else if (ortalama >= 70 && ortalama <= 85)
{
    Not = 4;
    Console.WriteLine("Notunuz: " + Not);
}
else if (ortalama >= 85 && ortalama <= 100)
{
    Not = 5;
    Console.WriteLine("Notunuz: " + Not);
}
else
{
    Console.WriteLine("Geçersiz Not Girdiniz.");
    return;
}