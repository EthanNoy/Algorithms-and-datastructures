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
            while (traveler != null)
            {
               if (traveler.Value > value)
                {
                    traveler = traveler.Left;
                }
               else if (traveler.Value < value)
                {
                    traveler = traveler.Right;
                }
               else if (traveler.Right.Value == value)
                {
                    if (traveler.Right.Right != null)
                    {
                        traveler.Right.Right = null;
                    }
                    if (traveler.Right.Left != null)
                    {
                        traveler.Right.Left = null;
                    }
                    return;
                }
            }
            // otherwise, for now, throw an InvalidOperationException


		}

		private class Node {

			public int Value;

			public Node Left;

			public Node Right;
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
