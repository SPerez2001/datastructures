using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    class searchingalgo
    {
        public class linearclass 
        {
            //public int[] array;
            //public int num;

            //public linearclass() 
            //{
            //    this.array = array;
            //    this.num = num;
            //}
            public static int linearsearch(int[] array, int num) 
            {
                int number = -1;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i] == num)
                    {
                        number = i;
                        return number;
                    }
                }
                return number;
            }

            public static void printal(int num) 
            {
                if (num != -1)
                {
                    Console.WriteLine("That number is in the array in the position of : " + num);
                }
                else
                {
                    Console.WriteLine("That number is not in the array");
                }
                
            }

        }

        public class binaryclass 
        {
            public static int binaryse(int[] array, int num) 
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right) 
                {
                    int mid = left + (right - left) / 2;
                    if (array[mid] == num) 
                    {
                        return mid;
                    }
                    if (array[mid] < num)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return -1;
            }
            public static void printal(int num)
            {
                if (num != -1)
                {
                    Console.WriteLine("That number is in the array in the position of : " + num);
                }
                else
                {
                    Console.WriteLine("That number is not in the array");
                }

            }
        }
    }
}
