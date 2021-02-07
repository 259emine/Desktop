using System;

namespace switchCaseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Birinci sayıyı giriniz: ");
           int x = Convert.ToInt32(Console.ReadLine());

           Console.Write("İkinci sayıyı giriniz: ");
           int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------İşlem Menüsü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1": Console.WriteLine($"{x} Sayısı ile {y} sayısının taplamı = {x+y} eder"); break;
                case "2": Console.WriteLine($"{x} Sayısı ile {y} sayısının farkı = {x-y} eder"); break;
                case "3": Console.WriteLine($"{x} Sayısı ile {y} sayısının çarpımı = {x*y} eder"); break;
                case "4": Console.WriteLine($"{x} Sayısı ile {y} sayısının bölümü = {(Convert.ToDouble(x)/y):f3} eder"); break;
                default: Console.WriteLine("Yanlış seçim"); break;
            }

        }
    }
}
