using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    abstract class Eigendom : Vak
    {
        private int prijs = 200;
        private int huur = 50;
        private Speler eigenaar = null;

        public override void Landen(Speler speler)
        {
            base.Landen(speler);

            if (eigenaar == null)
            {
                Console.WriteLine($"Wil je {Naam} kopen voor {prijs} euro? Y/N");
                string antwoord = Console.ReadLine();

                if(antwoord.ToLower().StartsWith('y'))
                {
                    eigenaar = speler;
                    speler.Transactie(-prijs);
                    Console.WriteLine($"\n{speler} heeft {Naam} gekocht! Deze speler heeft nog maar {speler.Geld} euro over!\n");
                }
                else
                {
                    Console.WriteLine("\nVolgende keer beter!");
                }
            }
            else if(speler != eigenaar)
            {
                Console.WriteLine($"Dit vakje is eigendom van {eigenaar}, u moet {huur} betalen.\n");
                speler.Transactie(-huur);
                eigenaar.Transactie(huur);
                Console.WriteLine($"{speler} heeft {huur} betaald aan {eigenaar}!\n");
            }
        }
    }
}
