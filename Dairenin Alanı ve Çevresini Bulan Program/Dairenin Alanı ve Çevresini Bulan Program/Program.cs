namespace Dairenin_Alanı_ve_Çevresini_Bulan_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yarıçap : ");
            double r = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;

            double alan = pi * r * r;
            double cevre = 2 * pi * r;
            Console.WriteLine("Dairenin Alanı : " + alan);
            Console.WriteLine("Dairenin Çevresi : " + cevre);
        }
    }
}
