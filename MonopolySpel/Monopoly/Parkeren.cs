using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Parkeren : Vak
    {
        private int pot = 0;

        public void Storten(int bedrag)
        {
            pot = pot + bedrag;
        }
    }
}
