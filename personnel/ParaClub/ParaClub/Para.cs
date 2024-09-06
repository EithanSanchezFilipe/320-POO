using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Para
    {
        public string Name;
        private int _y;
        private int _x;
        public bool paraOpen = false;
        private string[] withoutParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
        };

        public Para(int x)
        {
            _x = x;
        }
        public void Move()
        {
            if (_y >= Config.SCREEN_HEIGHT - 7)
            {
                paraOpen = false;
            }
            else
            {
                if (_y > Config.SCREEN_HEIGHT / 2)
                {
                    paraOpen = true;
                }
                if (!paraOpen)
                {
                    _y += 3;
                }
                else if (paraOpen)
                {
                    _y += 1;
                }
            }


        }
        public void Render()
        {
            for (int i = 0; i < withoutParachute.Length; i++)
            {

                Console.SetCursorPosition(_x, _y + i);
                Console.WriteLine(withoutParachute[i]);

            }
        }
    }
}
