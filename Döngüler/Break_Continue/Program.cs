

// string isim = "Muhammed Furkan Ateş";

// for(var i = 0; i < isim.Length; i++)
// {
//     if(isim[i] == 'r')
//     {
//         continue;
//     }
//     Console.WriteLine(isim[i]);
// }



int x = 0;

while ( x < 5)
{
    x++;
    if (x == 3)
    {
        continue;  //! break olsaydı döngüden çıkardı;

    }
    Console.WriteLine(x);
    
}