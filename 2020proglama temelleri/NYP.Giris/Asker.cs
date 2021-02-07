using System;
namespace NYP.Giris
{
    class Asker
    {
        public string Adi;
        public string Soyadi;
        public string Memleketi;
        public DateTime TerhisTarihi;

        public Asker() //yapıcı method
        {
            Console.WriteLine("Askerlik başladı...");
        }

         public Asker(string Adi, string Soyadi)
         {
            this.Adi = Adi;
            this.Soyadi = Soyadi;
         } 

        public void KunyeOku()
        {
            Console.WriteLine(Adi + " "+ Soyadi +"," + Memleketi);
            Console.WriteLine("EMRET KOMUTANIM!!!");
        }

        public int SafakKac()  //birinci şafak 
        {
            return (TerhisTarihi - DateTime.Now).Days;
        }

        public int SafakKac(DateTime HangiGuneGore) //ikinci şafak
        {
            return (TerhisTarihi - HangiGuneGore).Days;
        }
    }
}