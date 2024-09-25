using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    class linkedlistclass
    {
        public class node
        {
            public int value;
            public node next;

            public node(int value) 
            {
                this.value = value;
            }
        }
        public static int printallnodes(node head)
        {
            int count = 1;
            node current = head;
            Console.WriteLine("the number is " + current.value);
            while (current.next != null)
            {
                current = current.next;
                Console.WriteLine("the number is " + current.value);
                count += 1;
            }
            return count;
        }
    }
}
