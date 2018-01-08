using System;
namespace Ethan
{
    public class SimpleStack
    {
        // NOTE: implement using an array, please!
        private int[] SimpleArray;
        private int Size;
        private int Pushpop;

        /// <summary>
        /// Creates a new stack with the specified capacity.
        /// </summary>
        /// <param name="capacity">Capacity.</param>
        public SimpleStack(int capacity)
        {
            SimpleArray = new int[capacity];
            Size = capacity;
            Pushpop = 0;
        }

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="item">Element to add to the stack</param>
        public void Push(int item) 
        {
            

                SimpleArray[Pushpop] = item;
                Pushpop++;
            

        }

        /// <summary>
        /// Removes the top element of the stack, and returns it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public int Pop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the number of elements in this stack.
        /// </summary>
        /// <returns>A count of how many elements are in the stack.</returns>
        public int Count () {
            throw new NotImplementedException();
        }

        public void PrintUnderlying() {

            foreach (var i in SimpleArray)
                Console.WriteLine(i);

        }

    }
}
