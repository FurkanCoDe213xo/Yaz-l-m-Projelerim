/*
   ! Strings: Karakter dizileri - reference => null
*/
/*
? Console.Write("adı: ");
? var ad = Console.ReadLine();

? Console.Write("soyad: ");
? var soyad = Console.ReadLine();

? Console.Write("yaş: ");
? var yas = Console.ReadLine();

? string concat
? string mesaj = ad +" "+ soyad + " isimli kişi "+ yas + " yaşındadır.";

? string interpolation
? string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

? Console.WriteLine(mesaj); */




string mesaj = "Ahmet Turan isimli kişi 20 yaşındadır.";

// var  sonuc = mesaj.Length; 
// var sonuc = mesaj.ToLower();
// var sonuc = mesaj.ToUpper(); 
// var sonuc = mesaj.Trim(); 
//  var sonuc = mesaj.Split(" ")[3];
// var sonuc = mesaj[]; 
// var sonuc = mesaj.StartsWith("B"); 
// var sonuc = mesaj.EndsWith("."); 
// var sonuc = mesaj.Contains("Ali"); 
// var sonuc = mesaj.IndexOf("kişi"); 
// var sonuc = mesaj.Substring(6 , 5); 
var sonuc = mesaj.Substring(6, 5); 

Console.WriteLine(sonuc);