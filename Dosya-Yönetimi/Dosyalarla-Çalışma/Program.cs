// Directory.CreateDirectory("temp");   //!Dosya Oluşturma
// Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");

// if(Directory.Exists("temp/deneme2")) {  //! Varmı
//     Directory.Delete("temp/deneme2");
// } else {
//     Console.WriteLine("silmek istediğiniz klasör yok");
// }


// string path = @"C:\temp";   //!Windows için @ kullanılır
// string path = "/Users/Muhammed Furkan Ateş/Desktop/temp";
string path = Directory.GetCurrentDirectory() + "/temp";

Console.WriteLine(path);

Directory.CreateDirectory(path);


