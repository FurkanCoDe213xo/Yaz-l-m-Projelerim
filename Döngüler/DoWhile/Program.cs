

// int i = 1;

// do{
//     Console.WriteLine(i);
//     i++;
// } while (i < 10);


Console.WriteLine("Adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;
do{
    Console.Write("Ürün adı: ");
    urunler[i] = Console.ReadLine() ?? "";
    i++;
} while (adet != i);

Console.WriteLine("Ürünleriniz: ");

for(var a = 0; i < urunler.Length; a++) {
    Console.WriteLine(urunler[a]);
}