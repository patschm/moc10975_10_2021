using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Verblijf
    {
        private List<Dier> dieren = new List<Dier>();

        public void Rammen()
        {
            foreach(Dier d in dieren)
            {
                d.GeluidMaken();
            }
        }
        public void VoegToe(Dier d)
        {
            if (Check(d))
            {
                dieren.Add(d);
            }
        }
        protected abstract bool Check(Dier d);
    }
}
