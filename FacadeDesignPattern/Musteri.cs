using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Musteri
    {
        private string isim;
        // Constructor
        public Musteri(string isim)
        {
            this.isim = isim;
        }
        public string Isim
        {
            get { return isim; }
        }
    }
}