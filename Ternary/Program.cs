int sayı = 10;

var sonuc = (sayı % 2 == 0) ?
                (sayı > 0) ? "Pozitif çift sayı" : "Negatif çift sayı" :
                (sayı > 0) ? "Pozitif tek sayı" : "Negatif tek sayı";

Console.WriteLine(sonuc);

// Alternatif olarak doğrudan Console.WriteLine içinde de kullanılabilir
Console.WriteLine((sayı % 2 == 0) ? "Sayı çift" : "Sayı tektir");

