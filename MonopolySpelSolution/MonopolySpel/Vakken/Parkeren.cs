using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySpel
{
    class Parkeren : Vak
    {
        private int pot = 0;

        public override void Landen(Speler speler)
        {
            base.Landen(speler);
            speler.Transactie(pot);
            Console.WriteLine($"{speler} neemt de pot van {pot} euro! De pot is nu leeg.");
            pot = 0;
        }

        public void Storten(int bedrag)
        {
            pot += bedrag;
            Console.WriteLine($"De pot bevat nu {pot} euro!");
        }
    }
}
