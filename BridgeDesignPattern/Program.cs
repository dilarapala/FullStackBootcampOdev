using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
   class Program
    {
        static void Main(string[] args)
        {
            TelefonIslem telefonIslem = new TelefonIslem(new Telefon());
            telefonIslem.Start();
            telefonIslem.Restart();
            telefonIslem.Shutdown();

            Console.WriteLine();

            TabletIslem tabletIslem = new TabletIslem(new Tablet());
            tabletIslem.Start();
            tabletIslem.Restart();
            tabletIslem.Shutdown();

            Console.WriteLine();

            BilgisayarIslem bilgisayarIslem = new BilgisayarIslem(new Bilgisayar());
            bilgisayarIslem.Start();
            bilgisayarIslem.Restart();
            bilgisayarIslem.Shutdown();

            Console.ReadKey();
        }
    }
}
