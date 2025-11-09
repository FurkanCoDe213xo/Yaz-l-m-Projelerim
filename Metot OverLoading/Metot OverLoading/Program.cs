namespace Metot_OverLoading
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;  
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum(2, 3, 4));
            Console.WriteLine(Sum(2,5));
        }
    }
}
