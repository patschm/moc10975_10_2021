using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Rots : Verblijf
    {
        protected override bool Check(Dier d)
        {
            return d is Aap;
        }
    }
}
