using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            OrderedList ol = new OrderedList();

            ol.Add(5);

            ol.Add(7);

            ol.Add(10);

            ol.Add(-4);

            ol.Print();


        }
    }
}
