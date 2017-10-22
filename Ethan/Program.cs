using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> testList = new List<int>();

            for (int i = 0; i < 20; i++) {
                testList.Add(rnd.Next(10));
            }

            ListTools.Print(testList);

            Console.WriteLine("Searching for 5");
            Console.WriteLine("Found first at " + ListTools.FindFirstIndex(testList, 5));

            Console.WriteLine("Searching for 5");
            Console.WriteLine("Found last at " + ListTools.FindLastIndex(testList, 5));


            Console.WriteLine("============= end =======================");
        }
    }
}
