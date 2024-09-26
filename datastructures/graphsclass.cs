using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    class graphsclass
    {
        private int Vertex;

        private List<Int32>[] adjacency;

        public graphsclass(int ver1) 
        {
            Vertex = ver1;
            adjacency = new List<int>[ver1];

            for (int i = 0; i < ver1; i++) 
            {
                adjacency[i] = new List<int>();
            }
        }

        public void Addnum(int ver1, int ver2) 
        {
            adjacency[ver1].Add(ver2);
        }

        public void graphss1(int num1)
        {
            bool[] visit = new bool[Vertex];

            Queue<int> queue = new Queue<int>();
            visit[num1] = true;
            queue.Enqueue(num1);

            while (queue.Count != 0) 
            {
                num1 = queue.Dequeue();
                Console.WriteLine("next -> " + num1);

                foreach (Int32 next in adjacency[num1]) 
                {
                    if (!visit[next]) 
                    {
                        visit[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        public void graphss2(int num1)
        {
            bool[] visit = new bool[Vertex];

            Stack<int> stack = new Stack<int>();
            visit[num1] = true;
            stack.Push(num1);

            while (stack.Count != 0)
            {
                num1 = stack.Pop();
                Console.WriteLine("next -> " + num1);

                foreach (int k in adjacency[num1])
                {
                    if (!visit[k])
                    {
                        visit[k] = true;
                        stack.Push(k);
                    }
                }
            }
        }

        public void PrintAdjancent() 
        {
            for (int i =0; i < Vertex; i++) 
            {
                Console.Write(i + ":[");
                string name = "";
                foreach (var j in adjacency[i]) 
                {
                    name = name + (j + ",");
                }
                name = name.Substring(0, name.Length - 1);
                name = name + "]";
                Console.Write(name);
                Console.WriteLine();
            }
        }
    }
}
