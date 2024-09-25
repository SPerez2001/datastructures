using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    public class stacksandqueues
    {
        //public static void Main() 
        //{
        //    Stack st = new Stack();

        //    st.Push("Mon Deng");
        //    st.Push("Pesto");
        //    st.Push("Cardi B");
        //    st.Push("Tina Snow");

        //    Console.WriteLine("Current Stack: ");

        //    foreach (var item in st) 
        //    {
        //        Console.Write(item + ", ");
        //    }
        //    Console.WriteLine();

        //    Console.WriteLine("Removing Values");
        //    st.Pop();

        //    Console.WriteLine("Current Stack after the removal: ");
        //    foreach (var item in st)
        //    {
        //        Console.Write(item + ", ");
        //    }


        //}

        public int[] array;
        public int top = -1;

        public stacksandqueues(int num)
        {
            array = new int[num];
            top = -1;
        }

        public void Push(int num) 
        {
            if (top == array.Length - 1) 
            {
                throw new StackOverflowException();
            }
            array[++top] = num;
        }

        public int Pop() 
        {
            if (top == -1) 
            {
                throw new InvalidOperationException();
            }
            return array[top--];
        }
    }
}
