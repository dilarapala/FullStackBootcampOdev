using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Telefon : Cihaz
    {
        public void Start()
        {
            Console.WriteLine("Telefon : Açılıyor");
        }

        public void Shutdown()
        {
            Console.WriteLine("Telefon : Kapanıyor");
        }

        public void Restart()
        {
            Console.WriteLine("Telefon : Yeniden Başlatılıyor");
        }
    }
}
