using System;

namespace FacadeDesignPattern
{
    internal class Kredi
    {
        public bool HasIyiKredi(Musteri c)
        {
            Console.WriteLine(c.Isim + " icin kredi kontrol et");
            return true;
        }
    }
}