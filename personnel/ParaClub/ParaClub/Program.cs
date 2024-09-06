﻿using System;
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
            Para bob = new Para("bob");
            
            while (plane._x < Config.SCREEN_WIDTH)
            {
                
                Console.Clear();
                plane.Render();
                plane.Move();
                Thread.Sleep(40);
                if (Console.KeyAvailable)
                {
                    var keyPressed = Console.ReadKey(true);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            break;
        }
                }
            }
            Console.ReadLine();
        }
    }
}
