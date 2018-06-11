using System;
using System.Collections.Generic;
namespace Ethan
{
    public class BinarySearchTree
    {
		private Node Root;


        public BinarySearchTree()
        {
        }

		public void Add(int value) {
			
			if (Root == null)
			{
				Node NEWNODE = new Node();
				Root = NEWNODE;
				Root.Value = value;
				return;
			}
   
			Node traveler = Root;
            while (traveler != null){
                if (traveler.Value > value)
                {
                   
                    if (traveler.Left == null)
                    {
                        Node NodezN = new Node();
                        traveler.Left = NodezN;
                        NodezN.Value = value;
						return;
					} else {
						traveler = traveler.Left;
					}
                }
                else if (traveler.Value <= value)
                {
                    
                    if (traveler.Right == null)
                    {
                        Node NodezN = new Node();
                        traveler.Right = NodezN;
                        NodezN.Value = value;
						return;
					} else {
						traveler = traveler.Right;
					}
                }
                
			}
         
		} 

		public bool Contains(int key) {

			Node traveler = Root;
			while (traveler != null)
			{
				if (traveler.Value == key)
				{
					return true;
				}
				else if (traveler.Value > key)
				{
					traveler = traveler.Left;
				}
				else if (traveler.Value < key)
				{
					traveler = traveler.Right;
				}
			}

			return false;
		}

		public void Remove(int value) {

            // note: you only need to implement this to remove a 'leaf'
            // a leaf is a node with null children
            Node traveler = Root;
            Node Before_Traveler = null;
            while (traveler != null)
            {
                if (traveler.Value > value)
                {
                    Before_Traveler = traveler;
                    traveler = traveler.Left;
                }
                else if (traveler.Value < value)
                {
                    Before_Traveler = traveler;
                    traveler = traveler.Right;
                }
                else {
                    RemoveNode(traveler, Before_Traveler);
                    return;
                }
            }
            // otherwise, for now, throw an InvalidOperationException

		}

        private void RemoveNode(Node traveler, Node Before_Traveler) {
            
            if (traveler.Right == null && traveler.Left == null)
            {
                if(Before_Traveler == null) {
                    Root = null;
                }
                else if (Before_Traveler.Left == traveler)
                {
                    Before_Traveler.Left = null;
                }
                else
                {
                    Before_Traveler.Right = null;
                }
                return;
            }
            else if (traveler.Right == null)
            {
                if (Before_Traveler == null)
                {
                    Root = traveler.Left;
                }
                else if (Before_Traveler.Right == traveler)
                {
                    Before_Traveler.Right = traveler.Left;
                }
                else if (Before_Traveler.Left == traveler)
                {
                    Before_Traveler.Left = traveler.Left;
                }
                return;
            }
            else if (traveler.Left == null)
            {

                if (Before_Traveler == null)
                {
                    Root = traveler.Right;
                }
                else if (Before_Traveler.Right == traveler)
                {
                    Before_Traveler.Right = traveler.Left;
                }
                else if (Before_Traveler.Left == traveler)
                {
                    Before_Traveler.Left = traveler.Right;
                }
                return;

            }
            else
            {

                // two child case

                // find the leftmost right node
                Node BottomText = traveler.Right;
                Node BottomTextParent = traveler;
                while (BottomText.Left != null)
                {
                    BottomTextParent = BottomText;
                    BottomText = BottomText.Left;
                }

                // swap the VALUES only of that node and the one we want to remove
                int temp = 0;
                temp = BottomText.Value;
                BottomText.Value = traveler.Value;
                traveler.Value = temp;

                // remove the leftmost right node
                RemoveNode(BottomText, BottomTextParent);
                return;
            }

        }

		private class Node {

			public int Value;

			public Node Left;

			public Node Right;
		}

        public class HomeworkIncompleteException : Exception {
            public HomeworkIncompleteException(string message) : base(message){
              
            }
        }

		const int maxDepth = 7;
		public override string ToString()
		{

			System.Text.StringBuilder builder = new System.Text.StringBuilder();

			Node traveler = this.Root;

			Queue<Node> nodes = new Queue<Node>();
			HashSet<Node> visited = new HashSet<Node>();

			nodes.Enqueue(this.Root);

			while(nodes.Count > 0) {

				Node node = nodes.Dequeue();

                if (node == null)
                    continue;

				builder.AppendLine(node.Value.ToString());

				builder.AppendLine("  left: " + (node.Left == null ? " null " : node.Left.Value.ToString()));
				builder.AppendLine("  right: " + (node.Right == null ? " null " : node.Right.Value.ToString()));

				if(node.Left !=null && !visited.Contains(node.Left)) {
					nodes.Enqueue(node.Left);
					visited.Add(node.Left);
				}
				if (node.Right != null && !visited.Contains(node.Right))
                {
					nodes.Enqueue(node.Right);
					visited.Add(node.Right);
                }


			}
         
			return builder.ToString();

		}

	}
}
