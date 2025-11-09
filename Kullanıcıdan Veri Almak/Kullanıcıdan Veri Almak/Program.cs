namespace Kullanıcıdan_Veri_Almak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("1. Sayı : ");
            
            // int number1 = int.Parse(input);
           
        int number1 = Convert.ToInt32 (Console.ReadLine());

            Console.Write("2. Sayı : ");

            int number2 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine(number1  + number2);     
        }
    }
}
