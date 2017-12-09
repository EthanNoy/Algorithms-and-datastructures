using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            OrderedList ol = new OrderedList();

            ol.Add(30);

            ol.Add(20);

            ol.Add(10);

            ol.Add(5);

            ol.Add(00);

            //Console.WriteLine("Contains 0?" + ol.Contains(0));

            //Console.WriteLine("Contains 777777?" + ol.Contains(777777));

            ol.Remove(10);

            ol.Print();

            Console.WriteLine("Underlying");

            ol.DebugPrintUnderlyingArray();


        }
    }
}
