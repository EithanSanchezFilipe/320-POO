using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    internal class Fridge : Container
    {
        public int Temperature { get; private set; }

        public Fridge(int Weight, int Temperature) : base(Weight)
        {
            this.Temperature = Temperature;
        }
    }
}
