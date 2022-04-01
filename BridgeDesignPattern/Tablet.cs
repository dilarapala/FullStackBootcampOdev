using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Tablet : Cihaz
    {
        public void Start()
        {
            Console.WriteLine("Tablet : Açılıyor");
        }

        public void Shutdown()
        {
            Console.WriteLine("Tablet : Kapanıyor");
        }

        public void Restart()
        {
            Console.WriteLine("Tablet : Yeniden Başlatılıyor");
        }
    }
}
