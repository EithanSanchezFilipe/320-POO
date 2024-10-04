using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Box
    {
        public static int ID;
        public int Kilogrammes;
        public Color Color;
        public Box(Dispatch dispatch)
        {
            dispatch.Boxes.Add(this);
        }
    }
}
