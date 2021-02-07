using System;

namespace NYP.Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            var asker1 = new Asker();
             

          //  Console.Write(asker1.Adi); //get
           // asker1.Adi = "Mehmet";   //set

            asker1.Adi = "ahMEt"; //Ahmet diye yazıcam 
            asker1.Soyadi = "çoKçaLIŞIR"; //ÇOKÇALIŞIR diye büyük yazıcam
            asker1.Memleketi = "Samsun";
           // asker1.TerhisTarihi = DateTime.Parse("28.05.2021");
            asker1.KunyeOku();

            var safak1 = asker1.SafakKac(); //1


            //--------------------------------------
            
            var asker2 = new Asker();
            asker2.Adi = "Mehmet";
            asker2.Soyadi = "Hiçdurmaz";
            asker2.Memleketi = "Adana";
            asker2.TerhisTarihi = DateTime.Parse("14.05.2021");
            asker2.KunyeOku();

            var safak2 = asker2.SafakKac(DateTime.Parse("01.05.2021")); //2
            
            //---------------------------------------------------------------

            var asker3 = new Asker()
            {
                Adi = "Hasan",
                Soyadi = "Haydaroğlu",
                Memleketi = "Ankara",
            };

            //-----------------------------------------------------------------------

            var asker4 = new Asker("Hüseyin", "Yorulmaz");

            //----------------------------------------------------------------------

            var asker5 = new Asker(); // bu kullanımı yasaklamak istiyoruz

            //Asker:class
            //asker99:object

            Asker asker99 = new Asker();
            asker99.KunyeOku();
        }

    }
}
