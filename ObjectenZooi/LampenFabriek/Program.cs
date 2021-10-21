using System;

namespace LampenFabriek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oerknal

            // Typenaam varnaam;
            Lamp lampobject = new TL { Kleur = ConsoleColor.Red, StarterTijd = 200 };
            lampobject.Aan();


            Console.WriteLine("============");

            Lamp l1 = new Lamp { Kleur = ConsoleColor.Red };
            l1.Lumen = 300;
            Console.WriteLine(l1.Lumen);
           // l1.lumen = 200;
            l1.Kleur = ConsoleColor.Red;

            l1.Aan();

            Console.WriteLine(l1.IsAan);
           // l1.Uit();
            //Console.WriteLine(l1.isAan);


            Lamp l2 = new Lamp();
            l2.Kleur = ConsoleColor.Green;
           // l2.lumen = 300;

            l2.Aan();
            Console.WriteLine("Hallo");
            l2.Uit();

            // Big crunch
        }
    }


   

}
