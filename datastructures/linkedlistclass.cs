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

        public class linkedclass 
        {
            private node head;
            public void printallnodes()
            {
                node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.value);
                    current = current.next;
                }
            }
        }

        
    }
}
