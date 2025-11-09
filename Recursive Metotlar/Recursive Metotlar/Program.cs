namespace Recursive_Metotlar;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci serisinin kaçıncı elemanını görmek istiyorsunuz?");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) // Base case
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive case
    }
}