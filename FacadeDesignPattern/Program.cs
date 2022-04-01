using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            Ipotek ipotek = new Ipotek();
            Musteri musteri = new Musteri("Dilara Pala");
            bool uygun = ipotek.UygunMu(musteri, 495768);
            Console.WriteLine("\n" + musteri.Isim + " " + (uygun ? "Kabul edildi" : "Red edildi"));
            Console.ReadKey();
        }
    }
}
