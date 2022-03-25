using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with a field - a reference 
    /// to an integer array. Describe operator methods for type casting 
    /// in the class. You must implement the following type casting rules. 
    /// When converting an object to text, a text string is returned with 
    /// the values of the array elements. When converting an object 
    /// to a number, the sum of the array elements is returned. When 
    /// converting a number to an object, the result is a new object with 
    /// an array size determined by the number being converted. 
    /// The array in the object is filled with zeros.
    /// </summary>
    internal class Ch8Task8
    {
        static void Main(string[] args)
        {
            int arraySize = InputChecker.EnterIntegerMoreThenZero();

            TaskClass obj = new TaskClass(arraySize, true);

            Console.WriteLine("Created object array: " + obj);

            Console.WriteLine();

            Console.WriteLine("Object to string cast: " + (string)obj + "\n");

            Console.WriteLine("Object to int cast: " + (int)obj + "\n");

            int newNum = InputChecker.EnterIntegerMoreThenZero();

            TaskClass newObj = (TaskClass)newNum;

            Console.WriteLine("Casted object array: " + newObj);
        }

        class TaskClass
        {
            readonly int[] array;

            public TaskClass(int arraySize)
            {
                array = new int[arraySize];
            }
            public TaskClass(int arraySize, bool fillArray)
            {
                array = new int[arraySize];
                if (fillArray) FillArrayByRandom();
            }

            public static implicit operator string (TaskClass obj)
            {
                return obj.ToString();
            }

            public static implicit operator int (TaskClass obj)
            {
                return obj.array.Sum();
            }

            public static explicit operator TaskClass (int arraySize)
            {
                if(arraySize <= 0)
                {
                    return new TaskClass(1);
                }
                return new TaskClass(arraySize);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (int i in this.array)
                {
                    sb.Append(i.ToString() + ", ");
                }
                return sb.ToString().Trim(',', ' ');
            }

            public void FillArrayByRandom()
            {
                Random random = new Random();

                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 100);
                }
            }
        }
    }
}
