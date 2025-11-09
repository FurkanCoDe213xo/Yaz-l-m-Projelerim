
//?     -----Aritmatik Operatörler-----

//!    Toplama , Çıkarma , Çarpma , Bölme , Mod , Arttırma , Azaltma

//Örnek :
int x = 2;    
int y = x++;


// var sonuc = a + b;
// var sonuc = a - b;
// var sonuc = a * b;
// var sonuc = a / b;
var sonuc = y % x;          //! 10 mod 3



Console.WriteLine(sonuc);


//?     -----Aritmatik Operatörler Uygulama-----

// Aritmetik Operatör Uygulamaları

// a = 10, b = 5, c = 20 ise c - a farkının b katı kaçtır?

// int? a = 50; int b = 20; ise a + b değerini hesaplayınız. (eğer a null ise sonuç nedir?)

// a=10 b=20 ise a=b--; atamasından sonra a ve b değerleri ne olur?

// Klavyeden girilen bir sayının tek / çift kontrolünü yapınız.

// int a = 10;
// int b = 5;
// int c = 20;
// var sonuc = (c - a) * b;

// int? a = null;
// int b = 20;

// var sonuc = (a ?? 0) + b;
// Console.WriteLine(sonuc);

// int a = 10;
// int b = 20;
// a = b--;

// Console.WriteLine(a);
// Console.WriteLine(b);

Console.Write("sayı: ");
int sayi = int.Parse(Console.ReadLine() ?? "0");
var sonuç = sayi % 2;

Console.WriteLine(sonuc); // 1 ise satı tek, 0 ise sayı çift


//?     -----Atama Operatörleri-----

// Atama Operatörleri

var a = 5;
var b = 10;

a += b; // a = a + b;
a += 5; // a = a + 5;
a -= b; // a = a - b;
a *= b; // a = a * b;
a /= b; // a = a / b;
a %= b; // a = a / b;

// Math
double sonun;

sonun = Math.Pow(2,3);
sonun = Math.Sqrt(25);
sonun = Math.Abs(-10);
sonun = Math.Round(4.5);
sonun = Math.Round(4.6);
sonun = Math.Round(4.4);
sonun = Math.Ceiling(4.4);
sonun = Math.Floor(4.6);
sonun = Math.Max(10,20);
sonun = Math.Min(10,20);

Console.WriteLine(sonuç);



//?     -----Karşılaştırma Operatörleri-----

// Karşılaştırma Operatörleri

int A = 5, B = 5, c = 10, d = 3;
string username = "sadikturan";
string password = "1234";

var sonum = (A == B); // true
sonum = (c == d);
sonum = (username == "sadikturan"); // true
sonum = (password == "12345");      // false

sonum = (a != b);
sonum = (a > c);
sonum = (a < c);
sonum = (a >= b);

// ternary
var sonuc2 = (a > b) ? "a büyük": (a == b) ? "a b eşit": "b büyük";

Console.WriteLine(sonuc2);


//?     -----Karşılaştırma Operatör Uygulamaları-----

// Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.

// Console.Write("yaşınız: ");
// var yas = Convert.ToInt32(Console.ReadLine());
// var sonuc = (yas >= 18) ? "ehliyet alabilirsiniz.":"ehliyet için yaşınız tutmuyor.";
// Console.WriteLine(sonuc);


// Girilen bir sayının işaretini kontrol ediniz.

// Console.Write("sayı: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc = (sayi > 0) ? "sayı pozitif":"sayı negatif";
// Console.WriteLine(sonuc);

// Girilen bir sayının tek/çift durumunu kontrol ediniz.

Console.Write("sayı: ");
var sayı = Convert.ToInt32(Console.ReadLine());
var sonuC = (sayi % 2 == 1) ? "sayı tek": "sayı çift";
Console.WriteLine(sonuC);



//?     -----Mantıksal Operatörler-----

//! Ve Operarörü = &&
//! Veya Operatörü = ||
//! Değil Operatörü =         !(true) => False       (ZITTINI ALIR.)



var r = true;
var t = true;
var p = false;
var u = false;

var sunuc = (r && t);

Console.WriteLine(sunuc);

sunuc = (p && u);
Console.WriteLine(sunuc);

//?  =====>   VEYA OPERATÖRÜ <======

sunuc = (r || t);


Console.WriteLine(sunuc);



//? =====> Değil <=====

sunuc = !p;

Console.WriteLine(sunuc);




//?      ======>  MANTIKSAL OPERATÖRLER UYGULAMA <=====

// Mantıksal Operatörler Uygulamaları

//! 1- Yaşı 18' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.

// int yas = 17;
// bool veli_izni = false;
// var sonuc = (yas >= 18 || veli_izni) ? "çalışabilir": "çalışamaz";
// Console.WriteLine(sonuc);

//! 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

// int not = 40;
// var sonuc = (not >= 50 && not <= 100) ? "geçti":"kaldı";
// Console.WriteLine(sonuc);

//! 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

// int ortalama = 65;
// int zayif = 0;

// var sonuc = (ortalama >= 70) ? 
//                 ((zayif == 0) ? "teşekkür alabilir":"zayıfınız olmaması gerekiyor.") :
//                 "notunuz en az 70 olmalıdır.";

// Console.WriteLine(sonuc);

//! 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

// string egitim = "lise";
// bool sigara_icme = false;
// var sonuc = ((egitim == "lisans" || egitim == "önlisans") && (!sigara_icme)) ? "işe girebilir": "işe giremez";
// Console.WriteLine(sonuc);

//! 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım.

string email = "furkangame2013@hotmail.com";
string kullanıcıadı = "FurkanAteş";
string şifre = "0704";

var snç = ((email == "furkangame2013@hotmail.com" || kullanıcıadı=="Furkan") && (şifre == "0704")) ? "başarılı":"başarısız";
Console.WriteLine(sonuc);
