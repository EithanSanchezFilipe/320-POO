using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Plane
    {
        public string[] PlaneView =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public int _x = 0;
        public void Move()
        {
            _x++;
        }
        public void Render()
        {
            int i = 0;
            foreach(string chainChar in PlaneView)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(chainChar + "\n");
                i++;
            }
                
        }
    }
}
