using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Speler
    {
        private List<Vak> bezoekers = new List<Vak>();
        private List<Stad> steden = new List<Stad>();
        public Vak Locatie { get; set; }
        private int Geld { get; set; } = 1000;
        public Bord bord;
        public int Laatsteworp { get; set; }

        public void Beurt(Dobbelsteen steen)
        {
         }
        public void Transactie(int bedrag)
        {
        }

    }
}
