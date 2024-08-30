using System;
using System.Threading;
namespace exercice_snail1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PV = 50;
            const int MAXPV = 50;
            Console.CursorVisible = false;
            for(int x = 0; x < MAXPV; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                for (int y = 0; y < x; y++)
                {
                    Console.Write(" ");
                }
                PV--;
                if (PV == 0)
                    Console.WriteLine("____");
                else
                    Console.Write("_@_ö");
                Thread.Sleep(50);
               

            }
            Console.ReadLine();
            
        }
    }
}
