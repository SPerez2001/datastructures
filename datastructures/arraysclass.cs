using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures
{
    internal class arraysclass
    {
        public static void Main() 
        {
            Console.WriteLine("The given array: ");
            int[] sampleArray = {15,20,30,22,16 };
            foreach (var item in sampleArray)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The updated array: ");
            sampleArray[0] = 23;
            sampleArray[1] = 24;
            foreach (var item in sampleArray)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        public class Animal
        {
            public string type;
            public string name;
            public string color;

            public Animal(string t, string n, string c) 
            {
                this.type = t;
                this.name = n;
                this.color = c;
            }

            public void introduceSelf() 
            {
                Console.WriteLine("The Type of Animal this is " + this.type);
                Console.WriteLine("The Name of this animal is " + this.name);
                Console.WriteLine("The Color of this animal is " + this.color);
            }
        }

        public class Person
        {
            public string name;
            public string personality;
            public bool isSitting ;
            public Animal animal;

            public Person(string n, string p, bool i)
            {
                this.name = n;
                this.personality = p;
                this.isSitting = i;
            }

            public void sitDown()
            {
                this.isSitting = true;
            }

            public void standUp()
            {
                this.isSitting = false;
            }
            
        }
    }
}
