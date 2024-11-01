using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    internal class Container
    {
        public static int Id { get; private set; }
        public int Weight { get; private set; }

        public Container(int Weight) 
        {
            Id++;
            this.Weight = Weight;
        }
    }
}
