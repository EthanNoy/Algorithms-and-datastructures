using System;
using System.Collections.Generic;

namespace Ethan
{
    public static class BubbleSort
    {

        /* this is Ethan this time making sure we can commit */

        /// <summary>
        /// Sort the specified list using bubblesort.
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="values">A list of integers to sort.</param>
        public static void Sort (List<int> values) {
            
            for (int left_address = 0; left_address < values.Count; left_address++)
            {

                for (int right_address = values.Count - 1; right_address > left_address; right_address--)
                {
                    if (values[left_address] > values[right_address])
                    {
                        int left_value = values[left_address];
                        int right_value = values[right_address];
                        values[left_address] = right_value;
                        values[right_address] = left_value;


                    }
                }
            }

        }


    }
}
