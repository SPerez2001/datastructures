using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class divideandcon
    {

        public static void mergesor(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                mergesor(array, left, middle);
                mergesor(array, middle + 1, right);
                mergecl(array, left, middle, right);
            }
        }

        public static void mergecl(int[] array, int left, int mid, int right)
        {
            int i = mid - left + 1;
            int j = right - mid;

            int[] lef = new int[i];
            int[] righ = new int[j];

            Array.Copy(array, left, lef, 0, i);
            Array.Copy(array, mid + 1, righ, 0, j);

            int k = 0;
            int l = 0;
            int p = left;


            while (k < i && l < j)
            {
                if (lef[k] <= righ[l])
                {
                    array[p] = lef[k++];
                    k++;
                }
                else
                {
                    array[p] = righ[l];
                    l++;
                }
                p++;
            }
            while (k < i)
            {
                array[p] = lef[k];
                k++;
                p++;
            }
            while (l < j)
            {
                array[p] = righ[l];
                l++;
                p++;
            }
        }

        

    }
}
