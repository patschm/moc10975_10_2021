using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Dobbelsteen
    {
        private Random ogen = new Random();

        public int Dobbelen()
        {
            return ogen.Next(1, 7);
        }
    }
}
