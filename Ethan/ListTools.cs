using System;
using System.Collections.Generic;

namespace Ethan
{
    public static class ListTools
    {

        /// <summary>
        /// Prints out the list.
        /// </summary>
        /// <param name="theList">The list.</param>
        public static void Print(List<int> theList) {
            
            Console.WriteLine("Here is the list!");
            for (int s = 0; s < theList.Count; s++){
                Console.WriteLine(theList[s]);

            }


        }


        /// <summary>
        /// Reverse the order of all entries in the specified list.
        /// </summary>
        /// <returns>The reverse.</returns>
        /// <param name="theList">The list.</param>
        public static void Reverse(List<int> theList) {
                // TODO Homework 10/16/17 correctly implement me!
                for (int left_address = 0; left_address < theList.Count; left_address++)
            {
                for (int right_address = theList.Count - 1; right_address < left_address; right_address--)
                {
                    if (theList[left_address] < theList[right_address])
                    {
                        int left_value = theList[left_address];
                        int right_value = theList[right_address];
                        theList[left_address] = right_value;
                        theList[right_address] = left_value;
                    }
                
                }
            }

        }



    }
}
