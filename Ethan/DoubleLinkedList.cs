using System;
using System.Collections;
using System.Collections.Generic;

namespace Ethan
{
	public class DoubleLinkedList
	{

		public Node Head
		{
			get;
			private set;
		}

		public Node Tail
		{
			get;
			private set;
		}

		public int Count
		{
			get
			{
				int count = 0;
				Node traveler = Head;
				if (Head == null)
				{
					return 0;
				}
				while (traveler != null)
				{
					count = count + 1;
					traveler = traveler.Next;
				}
				return count;
			}
		}

		public DoubleLinkedList()
		{
		}

		public void AddToHead(int value)
		{
			Node NewNode = new Node();
			NewNode.Value = value;

			if (Head == null && Tail == null)
			{
				Head = NewNode;
				Tail = NewNode;
				return;

			}

			else
			{
				NewNode.Next = Head;
				Head.Previous = NewNode;
				Head = NewNode;

			}

		}

		public void AddToTail(int value)
		{
			Node NewNode = new Node();
			NewNode.Value = value;

			if (Head == null && Tail == null)
			{
				Head = NewNode;
				Tail = NewNode;
				return;

			}

			else
			{
				NewNode.Previous = Tail;
				Tail.Next = NewNode;
				Tail = NewNode;
			}
		}

		public void Remove(int value)
		{

			Node traveler = Head;
            Node before_traveler = null;
            Node after_traveler = null;
            while (traveler != null)
            {
				before_traveler = traveler.Previous;
				after_traveler = traveler.Next;

                if (traveler.Value != value)
                {
                    traveler = traveler.Next;
                }
                else if (traveler.Value == value)
                {
                    if (traveler == Tail){
                        before_traveler.Next = null;
                        traveler.Previous = null;
                        Tail = before_traveler;
						traveler = null;
                    }
                    
                    else if (traveler == Head){
                        after_traveler.Previous = null;
                        traveler.Next = null;
                        Head = after_traveler;
						traveler = null;
                    }

					else if (traveler == Head && traveler == Tail)
					{
						Head = null;
						Tail = null;
						traveler = null;
					}
					else
					{
						before_traveler.Next = after_traveler;
						after_traveler.Previous = before_traveler;
                        traveler.Next = null;
						traveler.Previous = null;
						return;
					}
				}

			}
		}

		public void RemoveAll(int value) 
		{
				Node traveler = Head;
				while (traveler.Next != null){
				traveler = traveler.Next;
					traveler.Previous = null;
					Head = traveler;
				}
				if (traveler == Tail && traveler == Head){
					traveler = null;
					Head = null;
					Tail = null;
				}
				if (traveler.Next == null){
					traveler = null;
					Head = null;
					Tail = null;
				}
		}

		public void RemoveFirst()
		{
			Node traveler = Head;
			if (Head != null){
				traveler = traveler.Next;
				Head = traveler;
				if (traveler == Tail){
					Tail = null;
				}
				if (traveler != null){
					traveler.Previous = null;
				}
			}
			return;
		}

		public void RemoveLast()
		{
			Node traveler = Tail;
			if (Tail != null){
				traveler = traveler.Previous;
				Tail = traveler;
				if (Head == traveler){
					Head = null;
				}
				if (traveler != null){
					traveler.Next = null;
				}
			}
		}
        
		public bool Contains (int value) {
			Node traveler = Head;
			if (traveler == null){
				return false;
			}
			while (traveler != null){
				if (traveler.Value == value)
				{
					return true;
				}
				else if (traveler.Value != value)
				{
					traveler = traveler.Next;
				}

			}
			return false;
		}

		public override string ToString()
		{
			System.Text.StringBuilder builder = new System.Text.StringBuilder();

			builder.Append("From Head : ");

			Node traveler = Head;
			while (traveler != null)
			{
				builder.Append(traveler.Value);
				builder.Append(" -> ");
				traveler = traveler.Next;
			}

			builder.Append(" From Tail : ");

			traveler = Tail;
			while (traveler != null)
			{
				builder.Append(" <- ");
				builder.Append(traveler.Value);
				traveler = traveler.Previous;
			}

			return builder.ToString();
		}

		public class Node
		{

			public Node Next;

			public int Value;

			public Node Previous;

		}
	}
}
