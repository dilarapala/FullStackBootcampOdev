using System;

namespace FacadeDesignPattern
{
    public class Ipotek
    {
        Banka banka = new Banka();
        Borc borc = new Borc();
        Kredi kredi = new Kredi();
        public bool UygunMu(Musteri must, int tutar)
        {
            Console.WriteLine("Musteri {0} icin basvuruldu: {1:C} borc\n",
                must.Isim, tutar);
            bool uygun = true;
            // Basvuranin kredibilitesini kontrol et
            if (!banka.HasYeterliBirikim(must, tutar))
            {
                uygun = false;
            }
            else if (!borc.HasNoKotuBorc(must))
            {
                uygun = false;
            }
            else if (!kredi.HasIyiKredi(must))
            {
                uygun = false;
            }
            return uygun;
        }
    }
}
