
//?      -----DİZİ METOTLARI-----

//! Dizi Metotları (Array Methods)

string[] sehirler = { "İstanbul", "Rize", "Kocaeli" };
int[] plakalar = { 67, 53, 41 };
sehirler.SetValue("Sakarya", 0);

Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler, "Rize"));

Array.Sort(sehirler);
Array.Sort(plakalar);

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(sehirler.GetValue(1));

Array.Reverse(plakalar);
Array.Clear(sehirler);
Array.Clear(plakalar, 0, 1); // 0 değer silinir!


Console.WriteLine(plakalar);

Console.WriteLine(plakalar.GetValue(0));

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.GetValue(2));

//?      -----Array Slicing-----

string[] şehirler = { "zonguldak", "rize", "kocaeli", "istanbul", "ankara" };

var sonuc = şehirler[..3];     //! Baştan 3 e kadar ekrana yazar.

Console.WriteLine(sonuc.Length);   

foreach(var i in şehirler[0..3]) {

Console.WriteLine(şehirler);

}




//?      -----TEK BOYUTLU DİZİLER-----

//! string[]adlar = new string[5]
//! string[] adlar = {"Ahmet" , "Ali" , "Ayşe" , "Hasan" , "Canan"};


var kursAdi = ".net 9 ile c# programlama dersleri".Split(' ');  // Boşluk karakterinden ayırır.
Console.WriteLine(kursAdi[5]);


/* string[] isimler = new string[5];

 isimler[0] = "Ahmet";     //! Bu yolda verileri başlangıçta kaç adet olacağı belirlenir ve tek tek atama yapılır.
 isimler[1] = "Ali";   
 isimler[2] = "Canan";
 isimler[3] = "Çınar";
 isimler[4] = "Esra"; */

string[] isimler = { "Ahmet", "Ali","Canan", "Çınar", "Esra"};  //! 2 Yol Daha Hızlı. Aynı işlevi Görür.

int[] numaralar = new int[5];

numaralar[0] = 100;
numaralar[1] = 200;
numaralar[2] = 300;
numaralar[3] = 400;
numaralar[4] = 500;

Console.WriteLine($"{numaralar[0]} numaralı öğrenenin adı {isimler[0]}");
Console.WriteLine($"{numaralar[1]} numaralı öğrenenin adı {isimler[1]}");    
Console.WriteLine($"{numaralar[2]} numaralı öğrenenin adı {isimler[2]}");
Console.WriteLine($"{numaralar[3]} numaralı öğrenenin adı {isimler[3]}");
Console.WriteLine($"{numaralar[4]} numaralı öğrenenin adı {isimler[4]}");


Console.WriteLine(isimler[0]);  //! İsimler dizisinin 0. elamanını yazdırır.





//?       ------ÇOK BOYUTLU DİZİLER-----

//! int[,] sayilar = new int [3,5];   

string[] oğrenciler = { "Ali", "Ahmet", "Canan" };
int[,] notlar = new int[3, 3];
// Ali
notlar[0, 0] = 50;
notlar[0, 1] = 60;
notlar[0, 2] = 70;

// Ahmet
notlar[0, 0] = 50;
notlar[0, 1] = 80;
notlar[0, 2] = 90;

//Canan
notlar[0, 0] = 50;
notlar[0, 1] = 70;
notlar[0, 2] = 30;

var ortalama_1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
var ortalama_2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
var ortalama_3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;

Console.WriteLine($"{oğrenciler[0]} isimli öğrencinin not ortalaması : {ortalama_1}");
Console.WriteLine($"{oğrenciler[1]} isimli öğrencinin not ortalaması : {ortalama_2}");
Console.WriteLine($"{oğrenciler[2]} isimli öğrencinin not ortalaması : {ortalama_3}");





