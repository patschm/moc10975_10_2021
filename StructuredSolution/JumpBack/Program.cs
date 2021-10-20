using System;

namespace JumpBack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestForLoop();
            //TestWhileLoop();
            TestDoWhileLoop();
        }

        private static void TestDoWhileLoop()
        {
            // do while gebruik je als je niet weet hoe vaak je moet herhalen.
            // 1 of meer keer uitgevoerd.
            int x = 0;
            do
            {
                Console.WriteLine(x++);
            }
            while (x < 10);
        }

        private static void TestWhileLoop()
        {
            // while gebruik je als je niet weet hoe vaak je moet herhalen.
            // 0 of meer keer uitgevoerd
           int x = 0;
           while(x < 10)
            {
                Console.WriteLine(x++);
            }
        }

        static void TestForLoop()
        {
            // Gebruik for als je _exact_ weet hoe vaak je iets moet herhalen!!!!
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

        }
    }
}
