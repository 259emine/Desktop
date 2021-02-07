using System;

namespace şifreodev
{
    class Program
    {
        static void Main(string[] args)
        {
          string sifre;
          int hak = 3;
          bool bildi = true;
          do
          {
              if (hak <= 0)
              {
                  Console.WriteLine("Hakkınız Bitti !!!");
                  bildi = false;
                  break;
              }
              Console.Write("şifre [Sondan {0}. hakkınız] : ",hak--);
              sifre = Console.ReadLine();
          } while (sifre != "1234");
          if (bildi) Console.WriteLine("Girişiniz Onaylandı.");
        }
    }
}
