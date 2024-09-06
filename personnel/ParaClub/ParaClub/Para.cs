using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Para
    {
        private string Name;
        private int _y = 6;
        private int _x;
        private bool paraOpen = false;
        private bool isRender = false;
        private string[] withoutParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
        };
        private string[] withParachute =
{
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
     };

        public Para(int x)
        {
            _x = x +14;
        }
        public void Move()
        {
            int currentY = _y;
            if (currentY >= Config.SCREEN_HEIGHT - withParachute.Length - 1)
            {
                paraOpen = false;
                isRender = false;
            }
            else
            {
                if (currentY == Config.SCREEN_HEIGHT / 2)
                {
                    paraOpen = true;
                    isRender = false;

                }
                if (!paraOpen)
                {
                    _y += 2;
                }
                else if (paraOpen)
                {
                    _y += 1;
                }
                if(isRender == true)
                    Console.MoveBufferArea(_x, currentY, withoutParachute[0].Length, withoutParachute.Length, _x, _y);
            }


        }
        public void Render()
        {
            if (!isRender)
            {
                if (paraOpen)
                {
                    for (int i = 0; i < withParachute.Length; i++)
                   {
                        Console.SetCursorPosition(_x, _y+ i);
                        Console.WriteLine(withParachute[i]);
                    }
                    isRender = true;
                }
                else
                {
                    for (int i = 0; i < withoutParachute.Length; i++)
                    {

                        Console.SetCursorPosition(_x, _y + i);
                        Console.WriteLine(withoutParachute[i]);
                    }
                    isRender=true;
                }
            }
        }
    }
}
