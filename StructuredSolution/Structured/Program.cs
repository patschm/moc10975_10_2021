using System;

namespace Structured
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef getal A");
            string sA = Console.ReadLine();

            // string blabla = sA
            ToonNummer(sA);
            

            Console.WriteLine("Geef getal B");
            string sb = Console.ReadLine();
            ToonNummer(sb);

            int xA;
            xA = ConvertNummer(sA);
            
            int xB = ConvertNummer(sb);

            Console.WriteLine("aX=" + xA + ", xB=" + xB);
            Console.WriteLine($"aX={xA}, xB={xB}");
            Console.ReadLine();
        }

        // Procedure
        static void ToonNummer(string blabla)
        {
            int a = int.Parse(blabla);
            Console.WriteLine(a);
        }
        // Function
        static int ConvertNummer(string bliep)
        {
            int a = int.Parse(bliep);
            return a;
        }
    }
}
