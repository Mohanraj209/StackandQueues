﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------** Stacks and Queues **--------");
            Stack stack = new Stack();

            Console.WriteLine("Element present in the Stack");
            //stack.push(70);
            //stack.push(30);
            //stack.push(56);
            //stack.display();
            //stack.peek();
            //stack.pop();
            //stack.IsEmpty();
            //stack.display();
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.ReadKey();
        }
    }
}
