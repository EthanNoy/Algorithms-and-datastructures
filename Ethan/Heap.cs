using System;
namespace Ethan
{
    public class Heap
    {
        public class Node
        {
            public int Value;

            public Node Left;

            public Node Right;

            public Node Parent;
        }
        private Node Root;

        public int RemoveMin (){
            throw new NotImplementedException();
        }

        public int GetMin () {
            if (Root == null)
            {
                throw new InvalidOperationException("Cannot GetMin, the heap is empty.");
            }
            else
            {
                return Root.Value;
            }
        }

        public void Add (int value){
            if (Root == null){
                Node node = new Node();
                node.Value = value;
                Root = node;
                return;
            }
        }

        public bool Contains (int key){
            throw new NotImplementedException();
        }

        public Heap()
        {
        }
    }
}
