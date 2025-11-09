using System.Numerics;

namespace Metotlar
{
    internal class Program
    {
        static int Pow (int baseNumber, int exponent)
        { 
            int result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNumber;
            }
            return result; 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2,3));
            int baseNumber = 2;
            int exponent = 3;
            int result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNumber;
            }


        }
    }
}
