using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dierentuin zoo = ConstructZoo();
            zoo.Activeer();

        }

        private static Dierentuin ConstructZoo()
        {
            Dierentuin zoo = new Dierentuin();

            // Op jacht in donker Afrika
            Leeuw lion = new Leeuw();
            Tijger tijgert = new Tijger();
            OerangOetan oet = new OerangOetan();
            Gorilla bokito = new Gorilla();
            Sidderaal sid = new Sidderaal();
            ClownVis vis = new ClownVis();
            Wildebeest beast = new Wildebeest();
            Antilope ant = new Antilope();

            Aquarium bakwater = new Aquarium();
            bakwater.VoegToe(sid);
            bakwater.VoegToe(vis);
            bakwater.VoegToe(lion);
            zoo.Assemble(bakwater);

            Kooi kooi = new Kooi();
            kooi.VoegToe(lion);
            kooi.VoegToe(tijgert);
            zoo.Assemble(kooi);

            Rots rots = new Rots();
            rots.VoegToe(bokito);
            rots.VoegToe(oet);
            zoo.Assemble(rots);

            Steppe step = new Steppe();
            step.VoegToe(ant);
            step.VoegToe(beast);
            zoo.Assemble(step);

            return zoo;

        }
    }
}
