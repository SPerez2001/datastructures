using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace datastructures
{
    internal class sortclass
    {
        public class quicksortclass 
        {
            public void QuickSort(int[] array, int low, int high)
            {
                int len = array.Length;
               
                    if (low < high)
                    {
                        int pi = Partition(array, low, high);
                        QuickSort(array, low, pi - 1);
                        QuickSort(array, pi + 1, high);
                        
                    }
            }

            public int Partition(int[] array, int low, int high)
            {
                int pivot = array[high];
                int i = (low - 1);
                for (int j = low; j < high; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                int temp1 = array[i + 1];
                array[i + 1] = array[high];
                array[high] = temp1;
                return i + 1;
            }

            public void printal(int[] array)
            {
                Console.WriteLine("Quick Sort: ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
            }
        }

        public class bubblesort 
        {
            public void bubbles(int[] array) 
            { 
                int num = array.Length;
                for (int i = 0; i < num - 1; i++)
                {
                    for (int j = i + 1; j < num - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])  
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            public void printal(int[] array) 
            {
                Console.WriteLine("Bubble Sort: ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
            }
        }

        public class selectionsortcl 
        {
            public void selection(int[] array) 
            {
                int num = array.Length;
                for (int i = 0; i < num - 1; i++)
                {
                    int index = i;
                    for (int j = i + 1; j< num; j++)
                    {
                        if (array[j] < array[index]) 
                        {
                            index = j;
                        }
                    }
                    int temp  = array[index];
                    array[index] = array[i];
                    array[i] = temp;
                }
            }
            public void printal(int[] array)
            {
                Console.WriteLine("Selection Sort: ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
            }
        }

        public class insertionsortcl 
        {
            public void insertion(int[] array)
            {
                int num = array.Length;
                for (int i = 1;i < num;i++) 
                {
                    int k = array[i];
                    int j = i - 1;

                    while (j >= 0 && array[j] > k) 
                    {
                        array[j+1] = array[j];
                        j--;
                    }
                    array[j + 1] = k;
                }
            }
            public void printal(int[] array)
            {
                Console.WriteLine("Insertion Sort: ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
            }
        }

        public class mergesortcl 
        {
            public void mergesor(int[] array) 
            {
                if (array.Length < 2 ) 
                {
                    return;
                }

                int middle = array.Length / 2;
                int[] left = new int[middle];
                int[] right = new int[array.Length - middle];

                Array.Copy(array, left, middle);
                Array.Copy(array, middle, right, 0, array.Length - middle);

                mergesor(left);
                mergesor(right);
                mergecl(array, left, right);
            }

            public void mergecl(int[] array, int[]left, int[] right)
            {
                int i = 0, j = 0, k = 0;
                while (i < left.Length && j < right.Length) 
                {
                    if (left[i] <= right[j])
                    {
                        array[k++] = left[i++];
                    }
                    else 
                    {
                        array[k++] = right[j++];
                    }
                }
                while (i < left.Length)
                {
                    array[k++] = left[i++];
                }
                while (j < right.Length)
                {
                    array[k++] = right[j++];
                }
            }

            public void printal(int[] array) 
            {
                Console.WriteLine("Merge Sort: ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
            }
        }
        
    }
}
