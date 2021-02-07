using System;
namespace NYP.Giris
{
    class Asker
    {
       // public string Adi;
       // public string Soyadi;
        public string Memleketi;
        public DateTime TerhisTarihi;




        
        //-----------------------------------KAPSÜLLEME------------------------------------------------------
        private string adi;
        public string Adi
        {
            get { return adi; }
            set { adi = char.ToUpper(value[0])+ value.Substring(1).ToLower(); } //burda ilk harf büyük diğerleri ise küçük yazılıcak adların
        }
        //---------------------------------------------------------------------------

        private string soyadi;
        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value.ToUpper(); } //bu kısımda soyadlarını hepsini büyük harf ile yazar
        }
        

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