using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class BilgisayarIslem : AbstractIslem
    {
        public BilgisayarIslem(Cihaz cihaz) : base(cihaz)
        {
        }
        public override void Start()
        {
          cihaz.Start();
        }
        public override void Shutdown()
        {
            cihaz.Shutdown();
        }
        public override void Restart()
        {
            cihaz.Restart();
        }

    }
}
