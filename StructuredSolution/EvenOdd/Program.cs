using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = VraagGetal();
            bool isEven = BepaalEven(number);
            ToonStatus(number, isEven);

            for(int num = 1; num <= 25; num++)
            {
                isEven = BepaalEven(num);
                ToonStatus(num, isEven);
            }

            Console.ReadLine();
        }

        static void ToonStatus(int number, bool isEven)
        {
           if (isEven)
            {
                Console.WriteLine($"getal {number} is even");
            }
           else
            {
                Console.WriteLine($"getal {number} is oneven");
            }
        }

        static bool BepaalEven(int number)
        {
            int restant = number % 2;
            bool even = restant == 0;
            return even;
        }

        static int VraagGetal()
        {
            Console.Write("Geef getal: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
    }
}
