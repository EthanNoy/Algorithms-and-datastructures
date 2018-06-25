using System;
using System.Collections.Generic;

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

        private LinkedList<Node> leaves;

        public Heap()
        {
            leaves = new LinkedList<Node>();
        }

        public int RemoveMin (){

            Node leaf = leaves.Last.Value;
            leaves.RemoveLast();

            int temp = leaf.Value;
            leaf.Value = Root.Value;
            Root.Value = temp;
            BubbleDown(Root);
            int MinValue = leaf.Value;
            if (leaf.Parent == null)
            {
                //do nothing
            }
            else if (leaf.Parent.Right == leaf)
            {
                leaf.Parent.Right = null;
                leaves.AddFirst(leaf.Parent);
            }
            else if (leaf.Parent.Left == leaf)
            {
                leaf.Parent.Left = null;
            }

            leaf.Parent = null;

            return MinValue;



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

        public void Add (int value) {
            if (Root == null){
                Node node = new Node();
                node.Value = value;
                Root = node;
                leaves.AddLast(node);
                return;
            }

            Node nodeQ = new Node();

            nodeQ.Value = value;

            if (leaves.First.Value.Left == null)
            {
                nodeQ.Parent = leaves.First.Value;
                leaves.First.Value.Left = nodeQ;
                leaves.AddLast(nodeQ);
            }
            else if (leaves.First.Value.Left != null)
            {
                nodeQ.Parent = leaves.First.Value;
                leaves.First.Value.Right = nodeQ;
                leaves.AddLast(nodeQ);
                leaves.RemoveFirst();
            }

            BubbleUp(nodeQ);

        }

        public bool Contains (int key) {
            throw new NotImplementedException();
        }

        private void BubbleUp(Node node)
        {
            if (node.Parent == null)
            {
                return;
            }
            else if (node.Value < node.Parent.Value)
            {
                int temp = node.Value;
                node.Value = node.Parent.Value;
                node.Parent.Value = temp;
                BubbleUp(node.Parent);
            }
        }

        private void BubbleDown(Node node) {
            if (node.Left == null)
            {
                return;
            }

            else {
                Node smallerChild;
                if (node.Right == null){
                    smallerChild = node.Left;
                }
                else if (node.Left.Value > node.Right.Value){
                    smallerChild = node.Right;
                }
                else {
                    smallerChild = node.Left;
                }

                if (node.Value > smallerChild.Value)
                {
                    int temp = node.Value;
                    node.Value = smallerChild.Value;
                    smallerChild.Value = temp;
                    BubbleDown(smallerChild);
                }


            }

        }

    }
}
