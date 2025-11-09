using System;
namespace MethodsUYG
{
    class Program
    {
        static void Main(string[] args)
        {
            //   SORU OLUŞTURALIM
            var soru1 = new Soru()
            {
                SoruMetni = "Hangisi programlama dili değildir?",
                Seçenekler = new string[4] { "Python", "C#", "Java", "Html" },
                Cevap = "Html"
            };

            var soru2 = new Soru()
            {
                SoruMetni = "Hangisi popüler programlama dilidir?",
                Seçenekler = new string[4] { "Python", "C#", "Java", "Html" },
                Cevap = "C#"
            };

            var soru3 = new Soru()
            {
                SoruMetni = "Hangisi web programlama platformu değildir?",
                Seçenekler = new string[4] { "Django", "Asp.net", "Spring", "Python" },
                Cevap = "Python"
            };
                // Soru Yazdırma
            var sorular = new Soru[] { soru1, soru2, soru3 };
            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.SoruMetni);
                foreach (var seçenek in soru.Seçenekler)
                {
                    Console.WriteLine(seçenek);
                }
                    // Kontrol ve cevap alma
                Console.WriteLine("Cevabınız: ");
                var cevap = Console.ReadLine();

                if (soru.cevapKontrol(cevap))
                {
                    Console.WriteLine("Doğru Cevap");
                }
                else
                {
                    Console.WriteLine("Yanlış Cevap");
                }
            }
            
        }
    }
    class Soru
    {
        public string SoruMetni { get; set; }
        public string[] Seçenekler { get; set; }
        public string Cevap { get; set; }
        public bool cevapKontrol(string cevap)
        {
           return this.Cevap.ToLower() == cevap.ToLower();  
        }
    }



}