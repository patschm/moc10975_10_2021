using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    abstract class Vak
    {
        private List<Speler> bezoekers = new List<Speler>();
        private int index;
        private string naam;

        public int Index { get => index; set => index = value; }
        public string Naam { get => naam; set => naam = value; }
        internal List<Speler> Bezoekers { get => bezoekers; set => bezoekers = value; }

        virtual public void Landen(Speler speler)
        {
            Console.WriteLine($"{speler} is geland op {Naam}.\n");

            if (speler.Locatie.Index > Index)
            {
                Console.WriteLine($"{speler} is voorbij Start gekomen, en ontvangt 200 euro!");
                speler.Transactie(200);
            }

            speler.Locatie = this;
            Bezoekers.Add(speler);
        }

        public void Vertrekken(Speler speler)
        {
            bezoekers.Remove(speler);
        }

        public override string ToString()
        {
            return $"({naam}, {index})";
        }
    }
}
