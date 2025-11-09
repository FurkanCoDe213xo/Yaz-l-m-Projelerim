namespace Do_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 5);
        }
    }
}
