using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Dierentuin
    {
        private List<Verblijf> verblijven = new List<Verblijf>();

        public void Assemble(Verblijf v)
        {
            verblijven.Add(v);
        }

        public void Activeer()
        {
            foreach(Verblijf v in verblijven)
            {
                v.Rammen();
            }
        }
    }
}
