using System;

namespace ödevC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Ortalamanızı Girin");
            int ort = Convert.ToInt32(Console.ReadLine());

            if (ort >= 101)
            {
                Console.WriteLine("A+ ile geçtiniz tebrikler");
            }
            else if (ort >= 90)
            {
              Console.WriteLine("A ile geçtiniz devam böyle");  
            }
            else if (ort >=85)
            {
                Console.WriteLine("B1 ile geçtiniz iyi");
            }
            else if (ort >=80)
            {
                Console.WriteLine("B2 ile geçtiniz orta");
            }
            else if (ort >=75)
            {
                Console.WriteLine("B3 ile geçtiniz eh işte");
            }
            else if (ort >=70)
            {
                Console.WriteLine("C1 ile geçtiniz");
            }
            else if (ort >= 65)
            {
                Console.WriteLine("C2 ile geçtiniz dikkat edelim");
            }
            else if (ort >= 60)
            {
                Console.WriteLine("C3 ile geçtiniz bence toparlan");
            }
            else if (ort >= 50)
            {
                Console.WriteLine("F1 ile kaldınız tüh");
            }
            else 
            {
                Console.WriteLine("F2 ile kaldınız demiştim ama dikkat edin diye");
            }

            Console.WriteLine(ort >= 60 ? "Geçtiniz" : ort>50? "Kritik":"Kaldınız");

        }
    }
}
