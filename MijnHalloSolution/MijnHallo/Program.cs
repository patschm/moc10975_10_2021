using System;


namespace MijnHallo
{

    class Program
    {

        static void Main(string[] args)
        {
            // Big bang

            const int nummer = 42;
            Console.WriteLine(nummer);

            //nummer = 42;

            bool b1;
            b1 = 4 == 4;

            double r1 = 3 % 3; // Binaire operator
            Console.WriteLine(r1);
            //r1++;

            r1 += 3;

            char chu9oio = 'A';
            string name = "jkhjkdhjkwehe";
            double f1 = 0.1000000000000008;
            Console.WriteLine(f1);

            Console.WriteLine("Geef uw naam");
            var naam = Console.ReadLine();
            Console.WriteLine("Hallo " + naam);
            Console.ReadLine();

            // Big Crunch
        }
    }
}
