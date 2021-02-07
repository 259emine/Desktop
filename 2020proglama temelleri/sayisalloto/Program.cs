using System;

namespace sayisalloto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int k = 0; k < 10; k++)
            {
                Console.Write($"{k+1}.kolon");
            //---kolon----(+10)----
            for (int i = 0; i < 6; i++) //i-->1,2,3,4,5, -->false
            {
              Console.Write( r.Next(1,50) + " " );
            }
             

                



                
            }


        }
    }
}
