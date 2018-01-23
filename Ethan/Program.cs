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

            Console.WriteLine("Popped:s " + s.Pop());

            s.PrintUnderlying();

        }
    }
}
