namespace Mantıksal_Operötorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            AND (&&): Her iki koşul da doğruysa (true) sonucu doğru döner.
            OR (||): Koşullardan en az biri doğruysa sonucu doğru döner.
            NOT (!): Koşulun tersini alır. Doğruysa yanlış, yanlışsa doğru yapar.*/
            
            int age = 25;
            bool hasLicence = true;

            string output = age > 18 && hasLicence == true ? "Araba Kullanabilirsin" : "Araba Kullanamazsın";
            Console.WriteLine(output);
        }
    }
}
