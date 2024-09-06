using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Plane plane = new Plane();
            
            while (plane._x < Config.SCREEN_WIDTH)
            {
                
                Console.Clear();
                plane.Render();
                plane.Move();
                Thread.Sleep(40);
            }
            Console.ReadLine();
        }
    }
}
