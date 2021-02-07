using System;

namespace cekilisyapılıyor
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rastgele = new Random();
           int[] sayilar = new int[5];
           int[] tahmin = new int[5];

           for (int j = 0; j < sayilar.Length; j++)
           {
              sayilar[j] = rastgele.Next(1,5);
           }
           for (int i = 0; i < sayilar.Length; i++)
           {
               Console.Write("{}. sayıyı giriniz:", i + 1);
               tahmin[i] = Convert.ToInt32(Console.ReadLine());
           }
            Console.WriteLine("---------sunuclar acıklandı----------");
            int x = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                int deger = Array.IndexOf(sayilar, tahmin[i] );


                if (deger == -1)
                {
                    Console.WriteLine("Tahmininiz Yanlış");
    
                }
                else
                {
                    Console.WriteLine("Tahmininiz"+deger+"indexte");
                    x++;
                }
                Console.WriteLine(x + "tane tahmininiz doğrudur");

                foreach (int eleman in sayilar)
                {
                   Console.WriteLine(eleman);
                }

                Console.ReadLine();
            }
        }
    }
}
