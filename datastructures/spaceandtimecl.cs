using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class spaceandtimecl
    {
        public class lineart 
        {
            public static int findnum(int[] array, int num)
            {
                int found = 0;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i] == num) 
                    {
                        found = 1;
                        return found;
                    }
                }
                return found;
            }
        }

        public class quadrat
        {
            public void bblsort(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
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
                Console.WriteLine("The Sorted Array: ");
                foreach (var num in array) 
                {
                    Console.Write(num + ", ");
                }
            }
        }
    }
}
