using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    public class Hayvanlar
    {
        public string hayvanAdi;       // property : Özellik
        public int ayakSayisi;         // Property : özellik
        public int kaloriGereksinimi;
        public int yemeİcme()
        {
            return kaloriGereksinimi * 30;
        }
    }
}
