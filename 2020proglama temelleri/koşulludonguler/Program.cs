using System;

namespace koşulludonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre;
            do
            { 

                Console.WriteLine("Lütfen Şifreyi Giriniz: ");
                sifre = Console.ReadLine();

            } while (sifre != "1234");

            Console.WriteLine("Giriş Onaylandı...");
            
        }
    }
}
