using System;

namespace şifreuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
           for (x = 3; x >= 1; x--)
           {
               Console.Write($"Lütefen Şifreyi Giriniz [Sondan {x}.Hakkınız]:");
               var sifre = Console.ReadLine();

               if(sifre == "1234")
               {
                   Console.WriteLine("Gidiğiniz Şifre Doğru");
                   break;
               }
               else Console.WriteLine("Girdiğiniz Şifre Yanlış");    
           }

           //doğal     x=0
           //break     x>0
            if (x>0) Console.WriteLine("Giriş Onaylandı");
            else Console.WriteLine("Hakkınız doldu, Giriş Reddedildi");
        }
    }
}
