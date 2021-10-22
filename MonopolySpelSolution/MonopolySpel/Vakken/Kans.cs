using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Kans : Vak
    {
        private static Random random = new Random();
        public Parkeren parkeren;

        public override void Landen(Speler speler)
        {
            base.Landen(speler);
            int bedrag = random.Next(-500, 500);
            speler.Transactie(bedrag);


            if (bedrag < 0) 
            {
                Console.WriteLine($"{speler} stopt {bedrag} euro in de pot.");
                parkeren.Storten(bedrag);
            }
            else
            {
                Console.WriteLine($"{speler} ontvangt {bedrag} euro van de kanskaart.");
            }
        }
    }
}
