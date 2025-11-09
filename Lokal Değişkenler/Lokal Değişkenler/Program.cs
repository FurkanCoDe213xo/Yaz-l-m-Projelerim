namespace Lokal_Değişkenler
{
    internal class Program
    {
        static void Sum(int x)
        {
             x = 10;
        }

        static void Main(string[] args)
        {
            int x = 5;
            Sum(x);
            Console.WriteLine(x);
        }

       
        
    }
}
