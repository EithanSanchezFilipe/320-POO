using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Plane
    {
        private string[] PlaneView =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public int _x = 0;
        private bool isRender = false;
        public void Move()
        {
            _x++;
            if (isRender == true)
                Console.MoveBufferArea(_x - 1, 0, PlaneView[0].Length, PlaneView.Length, _x, 0);
        }
        public void Render()
        {
            int i = 0;
            if (!(PlaneView[1].Length == 0))
            {
                foreach (string chainChar in PlaneView)
                {
                    if (isRender == false)
                    {
                        Console.SetCursorPosition(_x, i);
                        Console.Write(chainChar + "\n");
                        i++;
                    }
                    if (_x == Config.SCREEN_WIDTH - PlaneView[0].Length)
                    {
                        int y = 0;
                        foreach (string View in PlaneView)
                        {
                            PlaneView[y] = View.Substring(0, View.Length - 1);
                            y++;
                        }
                    }
                }
                isRender = true;
            }   
        }
    }
}
