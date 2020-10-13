using CrossAndZeroes;
using System;

namespace GameClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(new Board(), MakerType.Cross);
            while (!g.Status.IsFinished)
            {
                string value;
                Console.WriteLine("X");
                value = Console.ReadLine();
                int x = Convert.ToInt32(value);
                Console.WriteLine("Y");
                value = Console.ReadLine();
                int y = Convert.ToInt32(value);
                g.NextStep(x, y);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
