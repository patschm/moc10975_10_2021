using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenarij
{
    class Rekenmachine
    {
        public decimal getalA;
        public decimal getalB;
        public decimal resultaat;

        public void Optellen()
        {
            resultaat = getalA + getalB;
        }
        public void Aftrekken()
        {
            resultaat = getalA - getalB;
        }
        public void Vermenigvuldig()
        {
            resultaat = getalA * getalB;
        }
        public void Deel()
        {
            resultaat = getalA / getalB;
        }
    }
}
