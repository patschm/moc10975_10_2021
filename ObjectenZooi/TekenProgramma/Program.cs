using System;

namespace TekenProgramma
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas cv = new Canvas();
            Cirkel c1 = new Cirkel { Positie = new Positie { X = 100, Y = 200 }, Straal = 50 };
            Driehoek h1 = new Driehoek { Positie = new Positie { X = 200, Y = 200 }, Basis = 200, Hoek = 60, Hoogte = 300 };
            Rechthoek rh1 = new Rechthoek { Positie = new Positie { X = 100, Y = 200 }, Breedte = 200, Hoogte = 100 };

            cv.Add(c1);
            cv.Add(h1);
            cv.Add(rh1);

           // cv.Refresh();
        }
    }
}
