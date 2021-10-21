using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Wildebeest : Grazer
    {
        public override void GeluidMaken()
        {
            Console.WriteLine("De wildebeest knort");
        }
    }
}
