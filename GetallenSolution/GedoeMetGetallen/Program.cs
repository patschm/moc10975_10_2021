using System;

namespace GedoeMetGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal");
            string snum1 =  Console.ReadLine();
            Console.WriteLine("Geef nog een getal");
            string snum2 = Console.ReadLine();
            int numA = int.Parse(snum1);
            int numB = int.Parse(snum2);

            int resPlus = numA + numB;
            Console.WriteLine(resPlus);

            double resDiv = (double)numA / numB;
            Console.WriteLine(resDiv);

            bool gelijk = numA == numB;
            Console.WriteLine(gelijk);
           
            
            Console.ReadLine();
        }
    }
}
