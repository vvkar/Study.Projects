using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has static methods that 
    /// can be passed an arbitrary number of integer arguments 
    /// (or an integer array). Methods based on the passed arguments 
    /// or an array allow you to calculate the largest value, the smallest value, 
    /// and the average value from a set of numbers.
    /// </summary>
    internal class Ch6Task9
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int size = InputChecker.EnterInteger();

                var array = ArrayBuilder.GenerateIntArray(size);

                ArrayBuilder.WriteArray(array);

                MyClass.Calculate(array);
            }
        }

        class MyClass
        {
            public static void Calculate(int [] array)
            {
                if(array.Length > 0)
                {
                    int max = array[0];
                    int min = array[0];
                    double sum = 0;
                    double average;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                        else if (array[i] < min)
                        {
                            min = array[i];
                        }
                        sum += array[i];
                    }
                    average = (double)(sum / array.Length);

                    Console.WriteLine($"Max = {max}, min = {min}, average = {average:.00}");
                }
                else
                {
                    Console.WriteLine("Wrong array input!");
                }
            }
        }
    }
}
