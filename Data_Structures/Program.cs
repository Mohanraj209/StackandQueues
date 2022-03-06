using System;
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
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            Console.ReadKey();
        }
    }
}
