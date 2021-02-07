using System;

namespace degiskentanımlamaconvertformatlıgosterim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console. WriteLine("{0} sayısı ile {1} Sayısının toplamı = \"{2}\" eder. \nGörüşmek Dileğiyle...", sayi1, sayi2, toplam);
        }
    }
}
