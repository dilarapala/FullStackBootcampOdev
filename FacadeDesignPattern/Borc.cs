using System;

namespace FacadeDesignPattern
{
    public class Borc
    {
        public bool HasNoKotuBorc(Musteri c)
        {
            Console.WriteLine(c.Isim + " icin borclari kontrol et");
            return true;
        }
    }
}
