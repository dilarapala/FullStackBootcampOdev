using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Bilgisayar : Cihaz
    {
        public void Start()
        {
            Console.WriteLine("Bilgisayar : Açılıyor");
        }

        public void Shutdown()
        {
            Console.WriteLine("Bilgisayar : Kapanıyor");
        }

        public void Restart()
        {
            Console.WriteLine("Bilgisayar : Yeniden Başlatılıyor");
        }
    }
}