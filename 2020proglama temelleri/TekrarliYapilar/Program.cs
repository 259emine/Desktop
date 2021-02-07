using System;

namespace TekrarliYapilar
{
    class Program
    {
        static void Main(string[] args)
        {
                int x=0;
          tekrar:
            Console.WriteLine($"{++x}.kez Merhaba");
            if (x<5)   goto tekrar;
        }
    }
}
