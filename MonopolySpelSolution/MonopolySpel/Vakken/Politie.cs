using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Politie : Vak
    {
        public Cel cel;
        public override void Landen(Speler speler)
        {
            cel.Vangen(speler);
            cel.Landen(speler);
        }
    }
}
