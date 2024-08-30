using System;
using System.Threading;
using System.Collections.Generic;
namespace exercice_snail1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            List<Snail> snails = new List<Snail>();
            Snail toto = new Snail(10);
            snails.Add(toto);
            Snail titi = new Snail(20);
            snails.Add(titi);

            //Code
            Console.CursorVisible = false;
            while (toto.plife > 0)
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    snail.Render();
                    snail.Move();
                }
                Thread.Sleep(40);
            }
            foreach(Snail snail in snails)
                snail.Dead();
            Console.ReadLine();
        }
    }
}
