using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            OrderedList ol = new OrderedList();

            ol.Add(0);

            ol.Add(7);

            ol.Add(10);

            ol.Add(-4);

            //Console.WriteLine("Contains 0?" + ol.Contains(0));

            //Console.WriteLine("Contains 777777?" + ol.Contains(777777));

            ol.Print();

            Console.WriteLine("Underlying");

            ol.DebugPrintUnderlyingArray();


        }
    }
}
