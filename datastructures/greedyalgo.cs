using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class greedyalgo
    {
        public static void greedyclas(int[] array, int num)
        {
            Array.Sort(array);
            Array.Reverse(array);

            int am = 0;

            Console.WriteLine("Number to give change to the amount: ");
            foreach (int i in array) 
            {
                while (num >= i) 
                {
                    num -= i;
                    am++;
                    Console.WriteLine(i);
                }
                
            }

            if (num > 0)
            {
                Console.WriteLine($"Cannot give changes to the remaining number: {num}");
            }
            else 
            {
                Console.WriteLine($"Total number used: {am}");
            }
        }
    }
}
