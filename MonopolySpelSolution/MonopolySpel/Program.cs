using System;

namespace MonopolySpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Spel spel = new Spel();

            Speler mees = new Speler { naam = "Mees" };
            Speler bart = new Speler { naam = "Bart" };
            Speler patrick = new Speler { naam = "Patrick" };

            spel.Registreer(mees);
            spel.Registreer(bart);
            spel.Registreer(patrick);

            spel.Speel();
        }
    }
}
