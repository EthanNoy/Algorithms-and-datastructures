using System;
using System.Collections.Generic;

namespace Ethan
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            
            PalindromeTestes();
        }

        static void PalindromeTestes (){

            Console.WriteLine(ArraysAndStrings.IsPalindrome(" ta co c a t"));

        }

        static void BestMatchTests() {

            List<string> dictionary = new List<string>(new string[] { "rocket league", "the long dark", "ancient future", "rambo" });

            Console.WriteLine(ArraysAndStrings.BestMatch("rocket", dictionary));

            Console.WriteLine(ArraysAndStrings.BestMatch("the", dictionary));

            Console.WriteLine(ArraysAndStrings.BestMatch("league", dictionary));

            Console.WriteLine(ArraysAndStrings.BestMatch("futu", dictionary));

            Console.WriteLine(ArraysAndStrings.BestMatch("rpocketlegau", dictionary));

        }

        static void SetTests () {
            int[] BadLefty = new int[]{
                1,2,3,7,5
            };

            int[] Lefty = new int[]{
                1,2,3,4,5
            };
            int[] Righty = new int[]{
                4,2,3,1,5
            };

            Console.WriteLine(ArraysAndStrings.SameSet(Lefty, Righty));

            Console.WriteLine(ArraysAndStrings.SameSet(BadLefty, Righty));

        }

        static void HeapTests() {

            Heap heap = new Heap();

            heap.Add(1);
            heap.Add(7);
            heap.Add(8);
            heap.Add(29);
           
            heap.Add(5);
            heap.Add(80);

            Console.WriteLine("remove min: should be 1 " + heap.RemoveMin());

            Console.WriteLine("remove min: should be 5 " + heap.RemoveMin());

            Console.WriteLine("remove min: should be 7 " + heap.RemoveMin());

            Console.WriteLine("remove min: should be 8 " + heap.RemoveMin());

            Console.WriteLine("remove min: should be 29 " + heap.RemoveMin());

            Console.WriteLine("remove min: should be 80 " + heap.RemoveMin());

        }

		static void BSTTests(){

			BinarySearchTree tree = new BinarySearchTree();

			Console.WriteLine("Searching for 5: " + tree.Contains(5));
            
			tree.Add(10);
            tree.Add(8);
            tree.Add(6);
            tree.Add(15);
            tree.Add(12);
            tree.Add(10);
            tree.Add(20);

            Console.WriteLine(tree);

            Console.WriteLine("Removing 10");
            tree.Remove(15);

            Console.WriteLine(tree);

            Console.ReadLine();


		}

        static void DblLinkedListTests() {

            DoubleLinkedList list = new DoubleLinkedList();
            
            list.AddToTail(9);
            list.AddToTail(18);
            list.AddToTail(36);
			list.AddToTail(36);


            Console.WriteLine(list);

			Console.WriteLine("Searching for: 9: " + list.Contains(9));
			Console.WriteLine("Searching for: 27: " + list.Contains(27));
			Console.WriteLine("Searching for: 2: " + list.Contains(2));

            list.RemoveAll(36);



        }


        static void LinkedListTests()
        {
            
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            Console.WriteLine("Empty list length is..." + list.Count);

            list.AddToBeginning(555);
            list.AddToBeginning(5555);
			list.AddToEnd(5);
            list.AddToEnd(55);
            list.AddToBeginning(55555);
            list.AddToEnd(2);
            Console.WriteLine("Searching for: 5" + list.Contains(5));
            Console.WriteLine("Searching for: 7" + list.Contains(7));
            Console.WriteLine("Searching for: 2" + list.Contains(2));
            Console.WriteLine("List length is..." + list.Count);
            Console.WriteLine(list);

        }



        static void BinarySearchTests()
        {

            List<int> test = new List<int>();

            test.Add(10);
            test.Add(18);
            test.Add(32);
            test.Add(64);
            test.Add(66);
            test.Add(151);
            test.Add(250);
            test.Add(1001);

            Console.WriteLine("Found 10000000 at " + ListTools.BinarySearch(test, 60));

        }

        static void CooldownTests()
        {

            Cooldown c = new Cooldown(5);

            Console.WriteLine("Interval is " + c.GetInterval() + ", should be 5");

            Console.WriteLine("Trying to run at 1, success: " + c.Attempt(1));

            Console.WriteLine("Resetting!");
            c.Reset();

            Console.WriteLine("Trying to run at 2, success: " + c.Attempt(2));

            Console.WriteLine("At 3, time until next action is " + c.GetTimeUntilNextAction(3));

            Console.WriteLine("Trying to run at 3, success: " + c.Attempt(3));

            Console.WriteLine("Trying to run at 5.99, success: " + c.Attempt(5.99f));

            Console.WriteLine("Trying to run at 15, success: " + c.Attempt(15));

        }

        static void StackTests() {
            
            SimpleStack<int> s = new SimpleStack<int>(5);

            for (int i = 0; i < 20; i++)
            {
                s.Push(i);
            }

            s.PrintUnderlying();


        }

        static void QueueTests() {

            // Simple text case for SimpleQueue

            SimpleQueue<int> s = new SimpleQueue<int>();

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
