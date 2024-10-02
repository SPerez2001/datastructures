using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class backtrackingcl
    {
        public static void combinationcl(int[] array, int i, int first, List<int> current, List<List<int>> result)
        {
            if (current.Count == i) 
            {
                result.Add(new List<int>(current));
                return;
            }
            for (int j = first; j < array.Length; j++) 
            {
                current.Add(array[j]);
                combinationcl(array, i, j + 1, current, result);
                current.RemoveAt(current.Count -1);
            }
        }

        public void printal(List<List<int>> comb) 
        {
            Console.WriteLine("Combinations: ");
            foreach (var num in comb) 
            {
                Console.WriteLine(string.Join(", ", num));
            }
        }
    }
}
