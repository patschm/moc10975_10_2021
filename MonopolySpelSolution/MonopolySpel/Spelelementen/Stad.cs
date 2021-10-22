using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Stad
    {
        private string naam;
        List<Straat> straten = new List<Straat>();

        public string Naam { get => naam; set => naam = value; }
        internal List<Straat> Straten { get => straten; set => straten = value; }
    }
}
