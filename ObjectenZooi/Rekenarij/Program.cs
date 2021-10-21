using System;

namespace Rekenarij
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine calc = new Rekenmachine();
            calc.getalA = 6M;
            calc.getalB = 4M;

            calc.Optellen();
            Console.WriteLine(calc.resultaat);
            calc.Aftrekken();
            Console.WriteLine(calc.resultaat);
            calc.Vermenigvuldig();
            Console.WriteLine(calc.resultaat);
            calc.Deel();
            Console.WriteLine(calc.resultaat);
        }
    }
}
