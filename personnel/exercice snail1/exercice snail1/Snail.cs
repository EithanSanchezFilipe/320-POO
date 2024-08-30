using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_snail1
{
    internal class Snail
    {
        public int plife = 50;          //Points de vie
        public int x = 0;               //Position
        public int y = 10;
        public string alive = "_@_ö";   //escargot vivant
        public string dead = "____";    //escargot mort

        public Snail(int starty)
        {
            y = starty;
        }
        public void Move()
        {
            x++;
            plife--;
        }
        public void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(alive);
        }
        public void Dead()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(dead);
        }
    }
}
