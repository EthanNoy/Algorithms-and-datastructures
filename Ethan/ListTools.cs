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
		public static List<int> DeDupe(List<int> theList) {
			List<int> deduup = new List<int>();
			bool Isfound = false;
			for (int e = 0; e < theList.Count; e++)
			{
				Isfound = false;
				for (int i = 0; i < deduup.Count; i++)
				{
					if (theList[e] == deduup[i])
					{
						Isfound = true;
					}
				}
				if (Isfound == false)
					deduup.Add(theList[e]);
				
			}
			return deduup;
		}
		
		
		/// <summary>
		/// This function performs a binary search on the specified sortedList, looking for the specified search term.
		/// If it is found, this function returns its index in the list.  If not found, it returns -1.
		/// </summary>
		/// <returns>The search.</returns>
		/// <param name="sortedList">Sorted list.</param>
		/// <param name="search">Search.</param>
		public static int BinarySearch(List<int> sortedList, int search) {

            int Max = sortedList.Count-1;
            int Min = 0;
			int Mid = 0;
			int MidValue = 0;

            while (MidValue != search)
            {
                
                Mid = (Max + Min) / 2;
                MidValue = sortedList[Mid];

                if (MidValue == search)
                {
                    return Mid;
                }
                else if (MidValue < search)
                {
                    //Look at the bottom half of the cards
                    Min = Mid + 1;
                }
                else if (MidValue > search)
                {
                    //Look at the top half of the cards
                    Max = Mid - 1;
                }
                if(Min > Max) {
                    //WHAT IF MAX BECOMES SMALLER THAN MID?
                    throw new IndexOutOfRangeException();
                }
            
            }

            throw new InvalidOperationException();
		}
		
		
		
	}
}
