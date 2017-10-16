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
                testList.Add(rnd.Next(100));
            }


            ListTools.Print(testList);

            Console.WriteLine("Reversing...");
            ListTools.Reverse(testList);

            ListTools.Print(testList);


        }
    }
}
