using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            // Simple text case for SimpleQueue

            SimpleQueue s = new SimpleQueue();

            Console.WriteLine("Count:" + s.Count() + ", should be 0");

            s.Enqueue(10);

            s.Enqueue(20);

            s.Enqueue(30);

            Console.WriteLine("Count:" + s.Count() + ", should be 3");

            Console.WriteLine("Dequeue:" + s.Dequeue() + ", should be 10");

            Console.WriteLine("Count:" + s.Count() + ", should be 2");

            Console.WriteLine("Dequeue:" + s.Dequeue() + ", should be 20");

            Console.WriteLine("Count:" + s.Count() + ", should be 1");

            Console.WriteLine("Dequeue:" + s.Dequeue() + ", should be 30");

            Console.WriteLine("Count:" + s.Count() + ", should be 0");

        }
    }
}
