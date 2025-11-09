


string ad = "Ahmet";

foreach(char harf in ad)
{
    Console.WriteLine(harf);
}


int[] sayılar = { 10, 20, 40, 45 };

foreach (var sayı in sayılar)
{
    if (sayı == 20)
        continue;   //!  20 yi geçer!!
    Console.WriteLine(sayı);
}