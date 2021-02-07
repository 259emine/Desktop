using System;

namespace dizitanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {5,90,3,8,78,12};

         //   Array.Sort(a); //sıralama
         //   Array.Reverse(a);//ters

         //   foreach (var item in a)

   {
     //  Console.Write(item + " ");
   }

    if (Array.IndexOf(a,12) >= 0)
        Console.WriteLine (     "buldum"    );
    else Console.WriteLine(     "bulamadım"     );

        }
    }
}
