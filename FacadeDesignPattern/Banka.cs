using System;

namespace FacadeDesignPattern
{
    public class Banka
    {
        public bool HasYeterliBirikim(Musteri m, int tutar)
        {
            Console.WriteLine( m.Isim + " icin bankayi kontrol et");
            return true;
        }
    }
}
