using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            SimpleStack s = new SimpleStack(10);

            s.Push(64);

            s.Push(72);

            s.Push(7);

            s.Push(8);

            s.Push(24);

            s.PrintUnderlying();

<<<<<<< HEAD
            //Console.WriteLine("Contains 777777?" + ol.Contains(777777));

            ol.Remove(10);

            ol.Print();

            Console.WriteLine("Underlying");

            ol.DebugPrintUnderlyingArray();
=======
>>>>>>> bb30be7... Added SimpleStack work and assignment


        }
    }
}
