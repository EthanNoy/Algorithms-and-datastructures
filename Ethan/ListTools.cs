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
        public static void Print(List<int> theList)
        {

            Console.WriteLine("Here is the list!");
            for (int s = 0; s < theList.Count; s++)
            {
                Console.WriteLine(theList[s]);

            }

        }


        /// <summary>
        /// Reverse the order of all entries in the specified list.
        /// </summary>
        /// <returns>The reverse.</returns>
        /// <param name="theList">The list.</param>
        public static void Reverse(List<int> theList)
        {
            int MinI = 0;
            int MaxI = theList.Count - 1;
            while (MinI <= MaxI)
            {
                int Fetty_Swap = theList[MinI];
                theList[MinI] = theList[MaxI];
                theList[MaxI] = Fetty_Swap;
                MinI++;
                MaxI--;
            }

        }

        /// <summary>
        /// This function returns the first index of the searchkey in the list.
        /// If the key cannot be found, it returns -1
        /// </summary>
        /// <returns>The first index of the search key</returns>
        /// <param name="theList">The list to search through</param>
        /// <param name="searchKey">The number to search for</param>
        public static int FindFirstIndex(List<int> theList, int searchKey) 
        {
            for (int e = 0; e < theList.Count; e++)
            {
                if (theList[e] == searchKey)
                {
                    return e;
                }

            }
            return -1;
        }

        /// <summary>
        /// This function returns the last index of the searchkey in the list.
        /// If the key cannot be found, it returns -1
        /// </summary>
        /// <returns>The last index of the search key</returns>
        /// <param name="theList">The list to search through</param>
        /// <param name="searchKey">The number to search for</param>
        public static int FindLastIndex(List<int> theList, int searchKey)
        {
            for (int e = theList.Count-1; e >= 0; e--)
            {
                if (theList[e] == searchKey)
                {
                    return e;
                }

            }
            return -1;

        }

        /// <summary>
        /// Removes all duplicate integers from the list.
        /// </summary>
        /// <param name="theList">The list to de-duplicate</param>
        public static void DeDupe(List<int> theList) {

            throw new NotImplementedException();

        }

    }
}
