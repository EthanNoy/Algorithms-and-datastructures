using System;

namespace Ethan
{
    public class SimpleStack<T>
    {
        // NOTE: implement using an array, please!
        private T[] SimpleArray;

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
                SimpleArray = new T[capacity];
                Size = capacity;
                Pushpop = 0;
            }
            else{
                throw new ArgumentOutOfRangeException(nameof(capacity), "Unable to create a stack of negative size.");
            }
        }

        public SimpleStack()
        {
        }

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="item">Element to add to the stack</param>
        public void Push(T item) 
        {

            if (Pushpop < Size)
            {
                SimpleArray[Pushpop] = item;
                Pushpop++;
            }
            else{

                Console.WriteLine("~-Increasing Capacity-~");

                Size = Size != 0 ? Size * 2 : 4;

                T[] newArray = new T[Size];

                // copy the old array into this one
                Array.Copy(SimpleArray, newArray, SimpleArray.Length);

                // this is our new SimpleArray
                SimpleArray = newArray;

                // add the item
                SimpleArray[Pushpop] = item;
                Pushpop++;
            }
            

        }

        /// <summary>
        /// Removes the top element of the stack, and returns it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public T Pop()
        {
            if (Pushpop > 0)
            {
                Pushpop--;
                T result = SimpleArray[Pushpop];
                SimpleArray[Pushpop] = default(T);
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
        public T Peek() {
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
