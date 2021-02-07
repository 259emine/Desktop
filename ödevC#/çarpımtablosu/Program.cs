using System;

namespace çarpımtablosu
{
    class Program
    {
        static void Main(string[] args)
        {
          int c;
          for (int a = 1; a <= 10 ; a++)
          {
              for (int b = 1; b <= 10; b++)
              {
                c = a * b;
                 Console.WriteLine($"{a} x {b} = {c}");
              }
              Console.WriteLine("----------------------------");
          }
          Console.ReadKey();
        }
    }
}
