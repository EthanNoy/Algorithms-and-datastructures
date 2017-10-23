using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            List<int> test = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 30; i++) {

                test.Add(rnd.Next(5));
                
            }

            ListTools.Print(test);

            Console.WriteLine("De-duplicating...");
            ListTools.DeDupe(test);

            ListTools.Print(test);


        }
    }
}
