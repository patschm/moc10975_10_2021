using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Speler
    {
        private Vak locatie;
        private int geld = 10000;
        List<Vak> eigendommen = new List<Vak>();
        List<Stad> steden = new List<Stad>();
        public Bord bord;
        public string naam;

        internal Vak Locatie { get => locatie; set => locatie = value; }
        public int Geld { get => geld; set => geld = value; }

        public void Beurt(Dobbelsteen dobbelsteen)
        {
            int worp1 = dobbelsteen.Dobbelen();
            int worp2 = dobbelsteen.Dobbelen();

            Console.WriteLine($"{naam} heeft {worp1}  en {worp2} gerold, voor een totaal van {worp1+worp2}!");
            if(worp1==worp2)
            {
                Console.WriteLine($"{naam} is hierna nog een keer aan de beurt!");
            }
            Console.WriteLine();

            if (Locatie is Cel)
            {
                Cel cel = Locatie as Cel;
                if(cel.IsGevangen(this))
                {
                    if (worp1 == worp2)
                    {
                        cel.Vrijlaten(this);
                    }
                    else
                    {
                        Locatie.Landen(this);
                        return;
                    }
                }
            }

            locatie.Vertrekken(this);

            Vak nieuwVak = bord.Vraag(Locatie, worp1 + worp2);

            nieuwVak.Landen(this);
        }

        internal void Failliet()
        {
            throw new NotImplementedException();
        }

        public void Transactie(int bedrag)
        {
            Geld += bedrag;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
