using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class AbstractIslem
    {
        protected Cihaz cihaz;
        protected AbstractIslem(Cihaz cihaz)
        {
            this.cihaz = cihaz;
        }
        public abstract void Start();
        public abstract void Shutdown();
        public abstract void Restart();
      
    }
}
