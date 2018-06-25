using System;

namespace Ethan
{
    public class SingleLinkedList<T>
    {

        // a reference to the 'head' object
        public Node Head
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of entries in the linked list.
        /// </summary>
        /// <value>The count of entries.</value>
        public int Count
        {
            get
            {

                int count = 0;
                // count the number of nodes!
                Node traveler = Head;
                if (traveler == null){
                    return 0;
                }
                else{
                    
                    while (traveler != null)
                    {
						count = count + 1;
                        traveler = traveler.Next;
                    }

                }
                if (traveler.Next == null)
                {

                    return count;
                }
                else
                {
                    return int.MinValue;
                }
            }
        }

        public SingleLinkedList()
        {
        }

        /// <summary>
        /// Adds the specified value to the end of the linked list.
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddToEnd(T value)
        {

            // Creates the new node.
            Node nodes = new Node();
            nodes.Value = value;

            //If head is equal to null then the list is empty.
            //So we set head equal to the new node created.
            if (Head == null)
            {

                Head = nodes;
                return;
            }

            //Creates a var to get through the linked list and add a new node to the end
            Node traveler = Head;
            while (traveler.Next != null)
            {
                traveler = traveler.Next;
            }
            traveler.Next = nodes;

        }

        /// <summary>
        /// Adds the value to the beginning of the linked list.
        /// </summary>
        /// <param name="value">Value to add.</param>
        public void AddToBeginning(T value)
        {

            // Creates the new node.
            Node nodes = new Node();
            nodes.Value = value;

            //If head is equal to null then the list is empty.
            //So we set head equal to the new node created.
            if (Head == null)
            {

                Head = nodes;
                return;
            }

            nodes.Next = Head;
            Head = nodes;

        }

        public void RemoveFromBeginning()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("You cannot remove from the Linked List because it's empty, YOU'RE BAD!");
            }

            Head.Value = default(T);

            Node OldHead = Head;
            Head = Head.Next;
            OldHead.Next = null;
        }

        public void RemoveFromEnd()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("You cannot remove from the Linked List because it's empty, YOU'RE BAD!");
            }

            Node traveler = Head;
            Node Btraveler = null;
            while (traveler.Next != null)
            {
                Btraveler = traveler;
                traveler = traveler.Next;
            }

            if (Btraveler != null)
            {
                Btraveler.Next = null;
            }
            else
            {
                Head = null;
                Console.WriteLine("haha this list is empty inside...");
            }

            traveler.Value = default(T);

        }

        /// <summary>
        /// Returns true if the linked list contains the specified key, otherwise returns false.
        /// </summary>
        /// <returns>True if the linked list contains the specified key, otherwise false.</returns>
        /// <param name="key">Key to search for.</param>
        public bool Contains(T key)
        {

            Node traveler = Head;
            while (traveler != null)
            {
                if (!traveler.Value.Equals(key))
                {
                    traveler = traveler.Next;
                }
                else if (traveler.Value.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            Node traveler = Head;
            while (traveler != null)
            {
                builder.Append(traveler.Value);
                builder.Append(" -> ");
                traveler = traveler.Next;
            }
            return builder.ToString();
        }

        public class Node
        {

            public Node Next;

            public T Value;

        }

    }



}