namespace Not_Ortalamasını_Hesaplayan_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DERS NOTLARINI HESAPLAMA UYGULAMASINA HOŞGELDİNİZ! Notlar virgüllü ise , koyun!");
            Console.WriteLine("Lütfen Afet Notunu Girin : ");
            double Afet = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Beden Notunu Giriniz : ");
            double Beden = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Din Kültürü Notunu Girin : ");
            double Din = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Fen Notunu Girin : ");
            double Fen = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Görsel Sanatlar Notunu Girin : ");
            double Görsel = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Kültür ve Medeniyet Notunu Giriniz : ");
            double Kültür = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Matematik notunu giriniz : ");
            double Mat = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Müzik Notunu Giriniz : ");
            double Müz = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Rehber ve Yönlendirme notunu giriniz : ");
            double Reh = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Spor notunu giriniz : ");
            double Spor = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Sosyal notunu giriniz : ");
            double Sos = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Türkçe notunu giriniz : ");
            double Tr = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Teknoloji notunu giriniz : ");
            double Tek = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("İngilizce notunu giriniz");
            double İng = Convert.ToDouble (Console.ReadLine());

            double Toplam = Afet + Beden + Din + Fen + Görsel + Kültür + Mat + Müz + Reh + Spor + Sos + Tr + Tek + İng;
            double Ort = Toplam / 14;
            Console.WriteLine("NOT ORTALAMASI : " + Ort);
        }
    }
}
