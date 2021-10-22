using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Straat : Eigendom
    {
        private Stad mijnStad;

        internal Stad MijnStad { get => mijnStad; set => mijnStad = value; }

        public override void Landen(Speler speler)
        {
            base.Landen(speler);
        }
    }
}
