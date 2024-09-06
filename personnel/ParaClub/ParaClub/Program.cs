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
            List<Para> Parachutistes = new List<Para>();


            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable)
                {
                    var keyPressed = Console.ReadKey(true);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Parachutistes.Add(new Para(plane._x));
                            break;
                    }
                }
                plane.Move();
                foreach (Para para in Parachutistes)
                {
                    para.Move();
                }
                plane.Render();
                foreach (Para para in Parachutistes)
                {
                    para.Render();
                }
                Thread.Sleep(100);
            }
        }
    }
}
