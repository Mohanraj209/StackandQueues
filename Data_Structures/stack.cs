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
	}
}

