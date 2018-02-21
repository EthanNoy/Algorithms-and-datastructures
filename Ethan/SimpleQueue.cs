using System;
namespace Ethan
{

    /// <summary>
    /// A Queue is a data structure like a List, but it can only remove items in the order they were added.
    /// 
    /// see: https://en.wikipedia.org/wiki/Queue_(abstract_data_type)
    /// 
    /// This is a simple implementation, and only needs to store ints.
    /// Behind the scenes, it should use an array
    /// 
    /// </summary>
    public class SimpleQueue
    {
        // TODO create private variables here
        // I would like you to implement this with an Array

        // remember, you can allocate an array like this:
        // int[] data = new int[10];
        // where 10 is the size of array you want

        public SimpleQueue()
        {
        }

        // TODO adds an element to the queue
        public void Enqueue(int value) {
            throw new NotImplementedException();
        }

        // TODO removes the value at the front of the queue and returns it
        public int Dequeue()
        {
            throw new NotImplementedException();
        }


        // TODO returns the number of elements in the queue
        public int Count() {
            throw new NotImplementedException();
        }

        // TODO clears the queue of all elements
        public void Clear() {
            throw new NotImplementedException();
        }

        // TODO returns true if the queue contains the value
        // otherwise, returns false
        public bool Contains(int value) {
            throw new NotImplementedException();
        }


    }
}
