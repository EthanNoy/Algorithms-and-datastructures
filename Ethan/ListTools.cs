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
            int small_index = 0;
            int big_index = theList.Count-1;
            for (int e = 0; e < theList.Count; e++)
            {

                // all this does is change around index numbers, which you have 
                // created
                // additionally, it does not use your index counter 'e' at all..

                int temp = 0;
                temp = big_index;
                big_index = small_index;
                small_index = temp;

            }

        }



    }
}
