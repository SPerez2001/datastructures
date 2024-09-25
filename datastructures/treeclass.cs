using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class treeclass
    {
        public class node1 
        {
            public int value;
            public node1 left;
            public node1 right;

            public void show() 
            {
                Console.Write("{");
                Console.Write(value);
                Console.Write("}");
            }
        }

        public class tree
        {
            public node1 root;

            public tree()
            {
                root = null;
            }

            public node1 returntoroot() 
            {
                return root;
            }

            public void insert(int val) 
            {
                node1 node2 = new node1();
                node2.value = val;
                if (root == null)
                {
                    root = node2;
                }
                else 
                {
                    node1 current = root;
                    node1 parent;
                    while (true) 
                    {
                        parent = current;
                        if (val < current.value)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = node2;
                                return;
                            }

                        }
                        else 
                        {
                            current = current.right;
                            if (current == null) 
                            {
                                parent.right = node2;
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
