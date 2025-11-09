using System;
using System.Collections.Generic;
using System.Text;

namespace FarkliOdevDagitici
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Türkçe karakter desteği
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("=== HER ÖĞRENCİYE FARKLI ÖDEV (Matematik, Türkçe, Hayat Bilgisi) ===\n");

            //! 1. Öğretmen adı
            Console.Write("Öğretmen adı: ");
            string ogretmen = Console.ReadLine();

            //! 2. Öğrenciler
            List<string> ogrenciler = new List<string>();
            Console.WriteLine("\nÖğrencileri giriniz (bitirmek için boş bırakın):");
            while (true)
            {
                Console.Write("Öğrenci adı: ");
                string ogrenci = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ogrenci)) break;
                ogrenciler.Add(ogrenci.Trim());
            }

            if (ogrenciler.Count == 0)
            {
                Console.WriteLine("⚠️ En az bir öğrenci girilmeli!");
                return;
            }

            //! 3. Konular ve ödevler
            Dictionary<string, List<string>> konuOdevleri = new Dictionary<string, List<string>>();

            //! Matematik ödevleri
            konuOdevleri.Add("Matematik", new List<string>
            {
                "1'den 10'a kadar sayıları yaz", "Toplama işlemleri yap", "Çıkarma işlemleri yap",
                "1'den 20'ye kadar say", "Eksik sayıyı bul", "2 ile çarpma tablosu alıştırması",
                "3 ile çarpma tablosu alıştırması", "Basit toplama ve çıkarma problemleri",
                "Şekilleri say ve çiz", "Rakamları sırala", "Rakamlarla toplama yap", 
                "Rakamlarla çıkarma yap", "Parayı tanıma ve sayma", "Saatleri oku ve yaz", 
                "Uzunluk ölçümleri yap", "Ağırlık ölçümleri yap", "Geometrik şekilleri çiz", 
                "Basit grafik çizme", "Sayıları karşılaştır", "Toplama ve çıkarma problemleri çöz"
            });

            //! Türkçe ödevleri
            konuOdevleri.Add("Türkçe", new List<string>
            {
                "Kendi adını yaz", "Kelimeleri hecele", "Harfleri sırala", "Cümle kurma alıştırması",
                "Eksik harfi tamamla", "Resme bakarak cümle kur", "Kısa hikaye yaz", "Şiir yazma denemesi",
                "Kelimeleri eşleştir", "Kelimeleri yaz ve oku", "Cümlelerde noktalama işaretlerini koy",
                "Basit okuma parçasını oku", "Harflerle kelime oluştur", "Harfleri boyayarak öğren",
                "Kelimeleri kategorilere ayır", "Kendi hikayeni çizerek anlat", "Soru-cevap çalışması",
                "Hikaye tamamlama", "Cümleleri anlamına göre sırala", "Sesli harfleri bul"
            });

            //! Hayat Bilgisi ödevleri
            konuOdevleri.Add("Hayat Bilgisi", new List<string>
            {
                "Evdeki eşyaları say ve yaz", "Aile bireylerini çiz ve yaz", "Sağlıklı besinleri say",
                "Günlük rutinleri yaz", "Doğayı gözlemle ve not al", "Hayvanları ve yaşam alanlarını öğren",
                "Temizlik kurallarını yaz", "Güvenli davranışları listele", "Arkadaşlarına iyi davranışlar yaz",
                "Okul kurallarını say", "Toplumsal kuralları yaz", "Bitki gözlemi yap ve çiz",
                "Hava durumunu gözlemle", "Evde güvenli alanları göster", "Yaşadığın şehri tanıt",
                "Trafik kurallarını yaz", "Su tasarrufu ile ilgili not al", "Enerji tasarrufu önerileri yaz",
                "Geri dönüşüm malzemelerini say", "Acil durumları anlat"
            });

            //! 4. Konuların listesi
            Console.WriteLine("\nMevcut konular:");
            int sayac = 1;
            List<string> konularListesi = new List<string>();
            foreach (var konu in konuOdevleri.Keys)
            {
                Console.WriteLine($"{sayac}. {konu}");
                konularListesi.Add(konu);
                sayac++;
            }

            Console.Write("\nSeçmek istediğiniz konunun numarasını girin: ");
            int secim;
            bool gecerli = int.TryParse(Console.ReadLine(), out secim);

            if (!gecerli || secim < 1 || secim > konularListesi.Count)
            {
                Console.WriteLine("⚠️ Geçersiz seçim!");
                return;
            }

            string secilenKonu = konularListesi[secim - 1].Trim();

            //! Hata yakalama (örneğin Türkçe anahtar sorunu)
            List<string> secilenOdevler;
            try
            {
                secilenOdevler = new List<string>(konuOdevleri[secilenKonu]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"⚠️ '{secilenKonu}' adlı konu bulunamadı! (Türkçe karakter veya boşluk sorunu olabilir)");
                return;
            }

            //! Öğrenci sayısı ödev sayısından fazla mı?
            if (ogrenciler.Count > secilenOdevler.Count)
            {
                Console.WriteLine("⚠️ Uyarı: Öğrenci sayısı ödev sayısından fazla. Bazı ödevler tekrarlanacak.");
            }

            //! 5. Rastgele ödev dağıtımı
            Console.WriteLine($"\n📚 {ogretmen} tarafından seçilen konu: {secilenKonu}\n");
            Random rnd = new Random();

            foreach (var ogrenci in ogrenciler)
            {
                if (secilenOdevler.Count == 0)
                {
                    secilenOdevler = new List<string>(konuOdevleri[secilenKonu]);
                }

                int rastgeleIndex = rnd.Next(secilenOdevler.Count);
                string secilenOdev = secilenOdevler[rastgeleIndex];

                Console.WriteLine($"{ogrenci} adlı öğrenciye ödev: {secilenOdev}");

                secilenOdevler.RemoveAt(rastgeleIndex);
            }

            Console.WriteLine("\n🎉 Tüm ödevler başarıyla dağıtıldı!");
            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
