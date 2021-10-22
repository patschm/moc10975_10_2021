using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Vak
    {
        private List<Speler> bezoekers = new List<Speler>();

        public int Positie { get; set; }
        public string Naam { get; set; }

        public virtual void Landen(Speler speler)
            {}
    }
}

