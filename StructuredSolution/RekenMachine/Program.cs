using System;

namespace RekenMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            
            do
            {
                int a = VraagGetal("A");
                int b = VraagGetal("B");
                string op = WelkeOperatie();
                int result = Bereken(a, b, op);
                ToonBerekening(a, b, op, result);
                Console.WriteLine("Nog een berekening doen (Esc om te stoppen)");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
           
        }

        static int Bereken(int a, int b, string op)
        {
            int result;
            switch (op)
            {
                case "+":
                    result = TelOp(a, b);
                    break;
                case "-":
                    result = TrekAf(a, b);
                    break;
                case "*":
                    result = Vermenigvuldig(a, b);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        static int Vermenigvuldig(int a, int b)
        {
            return a * b;
        }

        static int TrekAf(int a, int b)
        {
            return a - b;
        }

        static string WelkeOperatie()
        {
            Console.WriteLine("Wat gaan we doen? ('+', '-', '*'");
            string op = Console.ReadLine();
            return op;
        }

        static int VraagGetal(string v)
        {
            Console.WriteLine($"Geeft getal {v}");
            string sNr = Console.ReadLine();
            int nr = int.Parse(sNr);
            return nr;
        }

        static int TelOp(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void ToonBerekening(int a, int b, string op, int result)
        {
            Console.WriteLine($"{a} {op} {b} = {result}");
        }
    }
}
