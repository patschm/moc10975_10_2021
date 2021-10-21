

using System;

namespace LampenFabriek
{
    // Blauwdruk van eenn object (een custom type)
    class Lamp
    {
        // Eigenschappen leg je vast in fields
        private int lumen = 200;
        //private ConsoleColor kleur = ConsoleColor.Yellow;
        protected bool isAan = false;

        public bool IsAan
        {
            get
            {
                return isAan;
            }
        }

        public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

        // Properties. Bedoeld om gecontroleerde toegang tot fields te faciliteren.
        public int Lumen
        {
            get
            {
                return lumen;
            }
            set
            {
                if (value >= 0)
                {
                    lumen = value;
                }
            }
        }


        // Gedrag. leg je vast in procedures of functions (methods)
        public virtual void Aan()
        {
            Console.BackgroundColor = Kleur;
            isAan = true;
            Console.WriteLine($"De lamp brandt met {lumen} lumen");
           
        }
        public void Uit()
        {
            isAan = false;
            Console.ResetColor();
            Console.WriteLine("De lamp is nu uit");           
        }

        // Constructors zijn bedoeld om fields een initiele waarde te geven
        public Lamp(int lm, ConsoleColor color)
        {
            lumen = lm;
            Kleur = color;
            isAan = false;
        }
        public Lamp()
        {

        }
    }
}