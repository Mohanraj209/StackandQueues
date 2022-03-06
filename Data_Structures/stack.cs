using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
	class Stack
	{
		private Node top;

		public Stack()
		{
			this.top = null;
		}

		internal void push(int data)
		{
			Node newNode = new Node(data);

			if (newNode == null)
			{
				Console.WriteLine("\n Stack Overflow");
				return;
			}

			newNode.data = data;

			newNode.next = top;

			top = newNode;
		}

		public void display()
		{ // print method
			Node temp = top;
			while (temp != null)
			{
				Console.WriteLine(temp.data + "-> ");
				temp = temp.next;

			}
		}

		public bool isEmpty()
		{
			return top == null;
		}

		internal int peek()
		{
			// check for empty stack
			if (!isEmpty())
			{
				return top.data;
			}
			else
			{
				Console.WriteLine("Stack is empty");
				return -1;
			}
		}

		internal void pop() // remove at the beginning
		{
			// check for stack underflow
			if (top == null)
			{
                Console.WriteLine("\nStack Underflow");
				return;
			}

			// update the top pointer to point to the next node
			top = (top).next;
		}

		internal void IsEmpty()
		{
			while (this.top != null)
			{
				peek();
				pop();
			}
            //this.top=null;
 
		}
	}
}

