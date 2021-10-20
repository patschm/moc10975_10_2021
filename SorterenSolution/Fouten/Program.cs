using System;

namespace Fouten
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
          

            try
            {  
                int y = int.Parse(Console.ReadLine());
                double result =  Divide(x, y);
                Console.WriteLine(result);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("Getal de root of te klein");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Ongeldig getal");
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("Delen door 0 is flauwekul");
                return;
            }
           catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
                Console.WriteLine("Das nie goe");
            }
            finally
            {
                Console.WriteLine("Tenslotte...");
            }
            Console.ReadLine();
        }

        static double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
