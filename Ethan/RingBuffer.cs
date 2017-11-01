using System;
using System.Collections.Generic;
namespace Ethan
{
    /// <summary>
    /// A ring buffer is a list of data of a specified capacity.
    /// 
    /// You can add data to the buffer.  When the buffer is full, the new entry
    /// will overrwrite the oldest entry.
    /// </summary>
    public class RingBuffer
    {

        private List<int> RingBoofer = new List<int>();

        private int KapaPride;

        private int SIIZ;

        public RingBuffer(int capacity)
        {
            KapaPride = capacity;
            SIIZ = 0;
        }

        /// <summary>
        /// Add the specified data. If the buffer is full, it replaces the 
        /// oldest entry.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="data">Data.</param>
        public void Add(int data)
        {
            if(RingBoofer.Count == KapaPride)
                RingBoofer.RemoveAt(0);
            RingBoofer.Add(data);
            

        }

        /// <summary>
        /// Gets the data at the specified 0-based index.  0 is the newest entry.
        /// </summary>
        /// <returns>The at.</returns>
        /// <param name="index">Index.</param>
        public int At(int index)
        {
            if (index < RingBoofer.Count && index >= 0)
                return RingBoofer[index];
            else
                throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// The number of entries in the buffer.
        /// </summary>
        /// <returns>The size.</returns>
        public int Size() {
            return SIIZ;
        }


        public void PrintMe(){
            for (int e = 0; e < RingBoofer.Count; e++){
                Console.WriteLine("item[" + e + "]=" + RingBoofer[e]);
            }

        }

    }
}
