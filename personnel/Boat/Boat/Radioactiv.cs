using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    internal class Radioactiv : Container
    {
        public int RandMax {  get; private set; }
        public Radioactiv(int Weight, int RandMax) : base(Weight)
        {
            this.RandMax = RandMax;
        }
    }
}
