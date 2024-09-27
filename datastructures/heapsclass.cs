using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    class heapsclass
    {
        public class node
        {
            public node left;
            public node right;
            public node parent;

            public int data;

            public node(int data)
            {
                this.data = data;
            }
        }

        public class Max_heap 
        {
            node root;
            node insert_pos;

            public Max_heap(node node) 
            {
                root = node;
                insert_pos = node;
            }

            private void balance_heap(node n) 
            {
                while (n.parent != null) 
                {
                    if (n.parent.data < n.data)
                    {
                        int tmp = n.data;
                        n.data = n.parent.data;
                        n.parent.data = tmp;

                        n = n.parent;
                    }
                    else 
                    {
                        break;
                    }
                }
            }

            public void insert(node n) 
            {
                if (insert_pos.left == null)
                {
                    insert_pos.left = n;
                    n.parent = insert_pos;

                    balance_heap(n);

                    return;
                }
                else 
                {
                    insert_pos.right = n;
                    n.parent = insert_pos;
                    adjust_insert();
                    balance_heap(n);
                }
            }

            private void adjust_insert() 
            {
                node node;

                Queue<node> q = new Queue<node>();
                q.Enqueue(root);
                while (q.Count > 0) 
                {
                    node = q.Dequeue();

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    else 
                    {
                        insert_pos = node;
                        break;
                    }

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    else 
                    {
                        insert_pos = node;
                        break;
                    }
                }
            }

            public void bfs_travers() 
            {
                node node;

                Queue<node> q = new Queue<node>();

                q.Enqueue(root);
                while (q.Count > 0)
                {
                    node = q.Dequeue();

                    Console.Write(node.data + " ");
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    
                }
            }
        }
    }
}
