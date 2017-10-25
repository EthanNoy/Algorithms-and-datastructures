using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            StatsCounter counter = new StatsCounter();

            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");
            counter.RegisterGoalScored("Steve");

            Console.WriteLine("Steve scored " + counter.GetGoals("Steve") + " goal(s)");

            Console.WriteLine("Ethan scored " + counter.GetGoals("Ethan") + " goal(s)");

        }
    }
}
