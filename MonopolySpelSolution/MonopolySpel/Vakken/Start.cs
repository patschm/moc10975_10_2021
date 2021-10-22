using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Start : Vak
    {
        public override void Landen(Speler speler)
        {
            Console.WriteLine($"{speler} is geland op {Naam}.\n");
            Console.WriteLine($"{speler} ontvangt 400 euro!");
            speler.Transactie(400);

            speler.Locatie = this;
            Bezoekers.Add(speler);
        }
    }
}
