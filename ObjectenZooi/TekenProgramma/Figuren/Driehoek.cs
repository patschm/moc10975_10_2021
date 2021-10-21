using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    class Driehoek : Figuur
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }
        public int Hoek { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Driehoek met basis {Basis} en hoogte {Hoogte} en hoek {Hoek} op positie {Positie}");
        }
    }
}
