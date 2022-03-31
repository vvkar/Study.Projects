using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a class that has a field - a reference 
    /// to an integer array. When an object is created, the array 
    /// is filled with random numbers. Override the ToString( ) method 
    /// in the class so that the method returns a text string with 
    /// the values ​​of the array elements and the average of the array elements.
    /// </summary>
    internal class Ch7Task10
    {
        static void Main(string[] args)
        {
            int size = InputChecker.EnterInteger("Enter size of an array: ");

            MyClass obj = new MyClass(size);

            Console.WriteLine(obj.ToString());
        }

        class MyClass
        {
            int[] array;

            public MyClass(int size)
            {
                this.array = new int[size];

                Random random = new Random();

                for(int i = 0; i < size; i++)
                {
                    array[i] = random.Next(1, 100);
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                foreach(var item in this.array)
                {
                    sb.Append(item.ToString() + ", ");
                }
                double average = ((double)this.array.Sum()) / (this.array.Length);

                string result = "Generated array: " 
                    + sb.ToString().Trim(' ', ',')
                    +$"\nAverage = {average:.00}";

                return result;
            }
        }
    }
}
