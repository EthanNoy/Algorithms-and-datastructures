﻿using System;
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
        // Note: you may not use SortedList to solve

        // Note: you may not to use Sort to solve

        // Note: Extra Credit if you solve with an array instead of a list

        List<int> ListInOrder = new List<int>();

        public OrderedList()
        {

        }

        public void Add(int value)
        {

            int insertIndex = 0;

            // Use this, but you must find the index to insert at
            ListInOrder.Insert(insertIndex, value);

        }


        public int Remove(int value)
        {

            throw new NotImplementedException();

        }


        public bool Contains(int value)
        {
            // Note: do not use the Contains() method of a list to solve

            // Since the list is sorted, can you search through the list
            // like a phone book - look in the middle, and which side
            // our value is on.  Then, search the middle of that half, etc...

            throw new NotImplementedException();

        }

        public void Print()
        {

            // this should be easy if your underlying list or array is already 
            // in order

            throw new NotImplementedException();

        }
    }
}
