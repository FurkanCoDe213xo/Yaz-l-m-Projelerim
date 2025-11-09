using System;

namespace AccessModifiers {

    class Program {

        static void Main(string[] args) 
        {
            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Html" }, "Html");
            var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "Html" }, "C#");
            var soru3 = new Soru(3, "Hangisi web programlama platformu değildir ?", new string[4] { "Django", "Asp.net", "Spring", "Python" }, "Python");
            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("html"));

            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru2cevapKontrol("C#"));

            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru3.cevapKontrol("Python"));

        }
    }

    class Soru {
        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = soruId;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }
        private int SoruId { get; set; }
        private string SoruMetni { get; set; }
        private string[] Secenekler { get; set; }
        private string Cevap { get; set; }
        public string SoruYazdir()
        {
            string soru = "";

            soru += this.SoruMetni + "\n";
            foreach(var secenek in this.Secenekler)
            {
                soru += secenek + "\n";

            }


            return soru;

        }
        
        public bool cevapKontrol(string cevap) 
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }
    }

}
