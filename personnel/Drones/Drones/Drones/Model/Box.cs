using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Box
    {
        public int ID;
        public int Kilogrammes;
        public Color Color;
        public Box(Dispatch dispatch ,int id, int kg, Color color)
        {
            ID = id;
            Kilogrammes = kg;
            Color = color;
            dispatch.CreateBox(this);
        }
    }
}
