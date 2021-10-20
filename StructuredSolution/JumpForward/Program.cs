using System;

namespace JumpForward
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Voor de if");

            if (a == 1)
            {
                Console.WriteLine("a is een");
            }
            else if (a == 2)
            {
                Console.WriteLine("a is twee");
            }
            else if (a == 3)
            {
                Console.WriteLine("a is drie");
            }
            else
            {
                Console.WriteLine("anders...");
            }

            Console.WriteLine("Begin");   
            switch(a)
            {
                case 1:
                    Console.WriteLine("a is een");
                    break;
                case 2:
                    Console.WriteLine("a is twee");
                    break;
                case 3:
                    Console.WriteLine("a is drie");
                    break;
                default:
                    Console.WriteLine("anders...");
                    break;
            }
              
            Console.WriteLine("Na de if");
        }
    }
}
