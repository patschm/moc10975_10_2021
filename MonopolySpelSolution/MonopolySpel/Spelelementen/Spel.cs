using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Spel
    {
        private Dobbelsteen d;
        private Bord bord;
        private List<Speler> spelers = new List<Speler>();

        public Spel()
        {
            bord = new Bord();
            d = new Dobbelsteen();
        }

        public void Speel()
        {
            int ronde = 1;

            do
            {
                Console.WriteLine($"Ronde {ronde}!\n\n");

                foreach(Speler speler in spelers)
                {
                    Console.WriteLine($"{speler} heeft momenteel {speler.Geld} euro.");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < spelers.Count; i++)
                {
                    Console.WriteLine($"Speler {spelers[i]} is aan de beurt.");

                    spelers[i].Beurt(d);
                    if (spelers[i].Geld < 0)
                    {
                        Console.WriteLine($"{spelers[i]} is failliet! Bye bye!");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                ronde++;
                Console.ReadKey();
                Console.Clear();
            }
            while (spelers.Count > 1);
        }

        public void Registreer(Speler speler)
        {
            spelers.Add(speler);
            speler.bord = bord;
            speler.Locatie = bord.GetStart();
        }
    }
}
