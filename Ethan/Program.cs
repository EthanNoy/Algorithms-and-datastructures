using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            /*
            StatsCounter counter = new StatsCounter();

            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");

            Console.WriteLine("Steve scored " + counter.GetGoals("Steve") + " goal(s)");

            Console.WriteLine("Ethan scored " + counter.GetGoals("Ethan") + " goal(s)");
            */
            RingBuffer ring = new RingBuffer(3);
            ring.Add(5);
            ring.Add(20);
            ring.Add(11);
            Console.WriteLine("After first third:");
            ring.PrintMe();
            ring.Add(0);
            Console.WriteLine("After the fourth:");
            ring.PrintMe();

            Console.ReadKey();
        }
    }
}
