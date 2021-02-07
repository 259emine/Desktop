using System;

namespace azalanyıldızlar
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 5;  i >= 1; i--)
           {
             for (int k = 1; k <= i; k++) Console.Write("*");
             Console.WriteLine();    
           }
            
        }
    }
}
