using System;

namespace ıcıceDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++)
            {
               for (int y = 0; y < x; y++)
               {
                   Console.Write("*");
               }
               Console.WriteLine(); //satır atla
            }
        }
    }
}
