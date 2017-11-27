using System;
using System.Collections.Generic;

namespace Ethan
{
    /// <summary>
    /// An OrderedList is always in order.
    /// 
    /// When you add an item, the list will remain in order
    /// 
    /// When you remove an item, the list will also remain in order.
    /// 
    /// </summary>
    public class OrderedList
    {

        // Note: first, create an orderedlist that holds only 10 items, max

        int[] ListInOrder;
        int Count;

        public OrderedList()
        {

            ListInOrder = new int[10];
            Count = 0;

        }

        public void Add(int value)
        {
            
            ListInOrder[Count] = value;
            Count++;

            // bubble last entry down
            bubbleDown();

        }

        void bubbleDown() {

            if (Count >= 2)
            {

                if (ListInOrder[Count - 1] <= ListInOrder[Count - 2])
                {
                    int temp = 0;
                    temp = ListInOrder[Count - 1];
                    ListInOrder[Count - 1] = ListInOrder[Count - 2];
                    ListInOrder[Count - 2] = temp;
                }

            }
        }


        public int Remove(int value)
        {

            throw new NotImplementedException();

        }


        public bool Contains(int value)
        {

            for (int e = 0; e < Count; e++){
                if (ListInOrder[e] == value){
                    return true;
                }

            }
            return false;

        }

        public int IndexOf(int value) 
        {

            // TODO implement me 11/27

            throw new NotImplementedException();

        }

        public void Print()
        {

            // this should be easy if your underlying array is already 
            // in order

            for (int d = 0; d < Count; d++){
                Console.WriteLine(ListInOrder[d]);

            }

        }

        public void DebugPrintUnderlyingArray()
        {
            
            for (int d = 0; d < ListInOrder.Length; d++)
            {
                Console.WriteLine(ListInOrder[d]);

            }

        }

    }
}
