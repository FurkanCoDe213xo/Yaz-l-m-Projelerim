//?          İF/ ELSE KULLANIMI

// string username = "admin";
// string password = "12345";

// if (username == "admin")    //! username admin eşit ise
// {
//     if (password == "123456")  //! password 123456 eşit ise
//     {
//         Console.WriteLine("Merhaba BTK Akademi");
//     }
//     else   //! password 123456 eşit değil ise
//     {
//         Console.WriteLine("Şifre hatalı");
//     }

// }

// else     //! username admin eşit değil ise
// {
//     Console.WriteLine("username hatalı");
// }  

//!    BÖYLEDE OLABİLİR

//  string username = "admin";
//  string password = "12345";

// if (username != "admin")
// {
//     Console.WriteLine("username hatalı");
// }  
// else if (password != "1234")
// {
//     Console.WriteLine("Şifre hatalı");
// }
// else
// {
//     Console.WriteLine("Merhaba BTK Akademi");
// }



int x = 10;
int y = 20;

if (x > y)
{
    Console.WriteLine("X, Y'den büyüktür");
}
else if (x < y)
{
    Console.WriteLine("X, Y'den küçüktür");
}
else if (x == y)
{
    Console.WriteLine("X, Y'ye eşittir");
}
