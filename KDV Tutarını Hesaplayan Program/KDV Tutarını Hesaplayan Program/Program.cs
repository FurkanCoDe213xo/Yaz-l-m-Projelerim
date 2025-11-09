namespace KDV_Tutarını_Hesaplayan_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100 , 20 , 120TL
            Console.Write("(Ürünüzün fiyatı virgüllü ise ',' koyun.Ürünün fiyatınız giriniz : ");
            double price = Convert.ToDouble(Console.ReadLine());

            double kdvRate = 0.20;

            double kdvPrice = price * kdvRate;

            double totalprice = price + kdvPrice;
            Console.WriteLine("KDV Tutarı : " + kdvPrice);
            Console.WriteLine("KDV'li tutar : " + totalprice);
         
        }
    }
}
