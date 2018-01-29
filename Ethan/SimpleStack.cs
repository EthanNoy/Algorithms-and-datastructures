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
            if (capacity > -1)
            {
                SimpleArray = new int[capacity];
                Size = capacity;
                Pushpop = 0;
            }
            else{
                throw new ArgumentOutOfRangeException(nameof(capacity), "Unable to create a stack of negative size.");
            }
        }

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="item">Element to add to the stack</param>
        public void Push(int item) 
        {

            if (Pushpop < Size)
            {
                SimpleArray[Pushpop] = item;
                Pushpop++;
            }
            else{
                throw new InvalidOperationException("Cannot push new elements onto a full SimpleStack");
            }
            

        }

        /// <summary>
        /// Removes the top element of the stack, and returns it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public int Pop()
        {
            if (Pushpop > 0)
            {
                Pushpop--;
                int result = SimpleArray[Pushpop];
                SimpleArray[Pushpop] = 0;
                return result;
            }
            else{
                throw new InvalidOperationException("Cannot pop an int from an empty stack.");
            }

        }

        /// <summary>
        /// Returns the top element of the stack, without removing it
        /// </summary>
        /// <returns>The top element of the stack</returns>
        public int Peek() {
            if (Pushpop > 0)
            {
                return SimpleArray[Pushpop - 1];
            }
            else{
                throw new InvalidOperationException("Could not peek at an empty stack.");
            }
        }

        /// <summary>
        /// Returns the number of elements in this stack.
        /// </summary>
        /// <returns>A count of how many elements are in the stack.</returns>
        public int Count () {
            return Pushpop;
        }

        public void PrintUnderlying() {

            foreach (var i in SimpleArray)
                Console.WriteLine(i);

        }

    }
}
