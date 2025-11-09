namespace Return_and_Void
{
    internal class Program
    {
        /*static void Sum (int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }  */

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {

            int result  = Sum(3, 1);
            Console.WriteLine(result);
            


        }
    }
}
