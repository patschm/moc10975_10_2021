using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampenFabriek
{
    class TL : Lamp // TL erft van lamp
    {
        public int StarterTijd { get; set; } = 100;
        
        public override void Aan()
        {
            Console.WriteLine($"Knipperdeknipper ({StarterTijd } ms)");
            Console.BackgroundColor = Kleur;
            isAan = true;
            Console.WriteLine($"De lamp brandt met {Lumen} lumen");

        }
        public void Uit()
        {
            isAan = false;
            Console.ResetColor();
            Console.WriteLine("De lamp is nu uit");
        }
    }
}
