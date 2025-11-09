using System.Data;

namespace Temel_Operatorler
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            int a = 6; int b = 3;
            int result = a / b;
            Console.WriteLine(result);
            result = a % b;
            Console.WriteLine(result);
            a += 5;
            Console.Write(a);

        }
    }
}
