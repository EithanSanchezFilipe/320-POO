using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Dispatch : IDispatchable
    {
        public List<Box> Boxes { get; set; }

        public Dispatch()
        { 
            Boxes = new List<Box>();
        }
        public void CreateBox(Box box)
        {
            Boxes.Add(box);
        }

        public void RemoveBox(Box box)
        {
            Boxes.Remove(box);
        }
    }
}
