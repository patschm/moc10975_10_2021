using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Cel : Vak
    {
        private Dictionary<Speler, int> gevangenen = new Dictionary<Speler, int>();

        internal Dictionary<Speler, int> Gevangenen { get => gevangenen; set => gevangenen = value; }

        public override void Landen(Speler speler)
        {
            if (IsGevangen(speler))
            {
                if (gevangenen[speler] == 0)
                {
                    Vrijlaten(speler);
                }
                else
                {
                    gevangenen[speler]--;
                }
            }
            else
            {
                base.Landen(speler);
            }
        }

        public void Vangen(Speler speler)
        {
            gevangenen.Add(speler, 3); // Wordt straks direct verlaagd naar 2.
        }

        public bool IsGevangen(Speler speler)
        {
            return gevangenen.ContainsKey(speler);
        }

        internal void Vrijlaten(Speler speler)
        {
            gevangenen.Remove(speler);
        }
    }
}
