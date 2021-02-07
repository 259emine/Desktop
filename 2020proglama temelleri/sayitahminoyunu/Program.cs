using System;

namespace sayitahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {

        yenioyun:
            int tutulan = new Random().Next(100) ; 

        tekrar:
            Console.Write("Tahmininiz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin < tutulan)
            {
                Console.WriteLine("Azalt");
                goto tekrar;
            }
            else if (tahmin < tutulan)
            {
                Console.WriteLine("Arttır");
                goto tekrar;
            }
            else
            {
                Console.WriteLine("Bildiniz");
                Console.Write("Tekara oynatmak istiyor musunuz? [E/H]");
                var secim = Console.ReadKey();
                if ( secim.Key == ConsoleKey.E)
                {
                    goto yenioyun;
                }
            }
        
        }
    }
}
