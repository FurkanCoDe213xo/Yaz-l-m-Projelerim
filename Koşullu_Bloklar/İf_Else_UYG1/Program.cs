//?   İf/Else Uygulaması

//? Kullanıcıya sunalan bir menü içinden seçim yaptırarak, seçilen işleme göre ekrana mesaj yazdıran bir program yazınız.

Console.WriteLine("Toplama için: +");
Console.WriteLine("Çıkarma için: -");
Console.WriteLine("Çarpma için: *");
Console.WriteLine("Bölme için: /");

Console.Write("Seçiminizi yapınız: ");
var secim = Console.ReadLine();

Console.Write("Birinci sayıyı giriniz: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());     //! Parse da kullanılabilir.

Console.Write("İkinci sayıyı giriniz: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

if (secim == "+")
{
   var sonuc = sayi1 + sayi2;
   Console.WriteLine("Toplama işlemi sonucu: " + sonuc);
}else if (secim == "-")
{
   var sonuc = sayi1 - sayi2;
   Console.WriteLine("Çıkarma işlemi sonucu: " + sonuc);
}else if (secim == "*")
{
    var sonuc = sayi1 * sayi2;
    Console.WriteLine("Çarpma işlemi sonucu: " + sonuc);
}else if (secim == "/")
{
    if (sayi2 != 0)
    {
        var sonuc = sayi1 / sayi2;
        Console.WriteLine("Bölme işlemi sonucu: " + sonuc);
    }
    else
    {
        Console.WriteLine("Bir sayı sıfıra bölünemez.");
    }
}else
{
    Console.WriteLine("Geçersiz işlem seçimi yaptınız.");
}
