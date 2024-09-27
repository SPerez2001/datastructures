using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class hashingclass
    {
        
        public class HashTable
        {
            public string[] hashArray;
            public int used = 0;
            public int arraysize;

            private bool IsPrimedNum(int capacity) 
            {
                for (int i = 2; i * i < capacity; i++) 
                {
                    if (capacity % i == 0) 
                    {
                        return false;
                    }
                }
                return true;
            }

            private int getNPrime(int num)
            {
                for (int i = num; ; i++)
                {
                    if (IsPrimedNum(i))
                    {
                        return i;
                    }
                }
            }

            public HashTable(int capacity) 
            {
                if (!IsPrimedNum(capacity)) 
                {
                    capacity = getNPrime(capacity);
                }
                arraysize = capacity;
                hashArray = new string[capacity];
            }

            public int hashFunction1(string word) 
            {
                int hashvalue = hashArray.GetHashCode();
                hashvalue = hashvalue % arraysize;

                if (hashvalue < 0) 
                {
                    hashvalue = hashvalue + arraysize;
                }
                return hashvalue;
            }

            public int hashFunction2(int hashvalue)
            {
                return 3 - hashvalue % 3;
            }

            public bool insert(string word) 
            {
                int hashvalue = hashFunction1(word);
                int stepnum = hashvalue % arraysize;

                while (hashArray[hashvalue] != null) 
                {
                    hashvalue = hashvalue + stepnum;
                    hashvalue = hashvalue % arraysize;
                }
                hashArray[hashvalue] = word;
                used++;
                Console.WriteLine("Insert Word " + word + " at index " + hashvalue + " total space used is " + used);
                return true;
            }

            public int find(string word) 
            {
                int hashvalue = hashFunction1(word);
                int stepnum = hashFunction2(hashvalue);

                while (hashArray[hashvalue] != null) 
                {
                    if (hashArray[hashvalue].Equals(word, StringComparison.InvariantCultureIgnoreCase)) 
                    {
                        return hashvalue;
                    }
                    hashvalue += stepnum;
                    hashvalue %= arraysize;
                }
                return -1;
            }
        }
    }
}
