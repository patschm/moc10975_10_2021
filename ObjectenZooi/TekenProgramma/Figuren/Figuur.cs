using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    abstract class Figuur
    {
        public Positie Positie { get; set; }

        public abstract void Teken();

    }
}
