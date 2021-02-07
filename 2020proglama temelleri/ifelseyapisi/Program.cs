using System;

namespace ifelseyapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ortalamanızı Girin: ");
            int ort = Convert.ToInt32(Console.ReadLine());
            // if (ort >= 60) 
            // {
            //     Console.WriteLine("Tebrikler");
            //     Console.WriteLine("Geçtiniz");
            // }
            // else if ( (ort >= 50) )
            // {
            //     Console.WriteLine("Hmm");
            //     Console.WriteLine("Durumunuz Kritik");
            // }
            // else
            // {
            //     Console.WriteLine("Üzgünüm");
            //     Console.WriteLine("Kaldınız");
            // }

           

            // Console.WriteLine(   ort >= 60 ? "Geçtiniz" : ort >= 50 ? "Kritik":"Kaldınız"    );
        }
    }
}
