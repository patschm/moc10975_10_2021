using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Add(Figuur figuur)
        {
            figuren.Add(figuur);
            Refresh();
        }

        public void Refresh()
        {
            Console.Clear();
            foreach(Figuur figuur in figuren)
            {
                figuur.Teken();
            }
        }
    }
}
