// While Döngüsü Uygulama

// Sayı Tahmin
// 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın.
// Tanımlanan hak bittiğinde oyun bitmeli.
Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz!");
Console.WriteLine("1 ile 50 arasında bir sayı tuttum. Bakalım bilebilecek misin?");
var rnd = new Random();
int tutulan = rnd.Next(1, 50);
int hak = 5;

while(hak > 0) {
    

    Console.Write("sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if(sayi == tutulan) {
        Console.WriteLine("tebrikler bildiniz");
        break;
    } 
    else {
        if(hak == 0) {
            Console.WriteLine("oyun bitti");
            break;
        }
        if(tutulan > sayi) {
            Console.WriteLine("Sayını Arrtır");
            Console.WriteLine("Kalan hak: " + hak);
        } else {
            Console.WriteLine("Çok gittin Yavaş ol ve Sayını AZALT");
            Console.WriteLine("Kalan hak: " + hak);
        }
    }
}