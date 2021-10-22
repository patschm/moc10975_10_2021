using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Dobbelsteen
    {
        private Random dobbelsteen = new Random();

        public int Dobbelen()
        {
            return dobbelsteen.Next(6) + 1;
        }
    }
}
