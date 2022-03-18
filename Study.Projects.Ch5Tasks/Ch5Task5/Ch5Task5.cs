using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes 
    /// an integer array as an argument and returns 
    /// the average value of the array elements as a result.
    /// </summary>
    internal class Ch5Task5
    {
        static void Main(string[] args)
        {
            int size = InputChecker.EnterPositive("Enter a size of an array: ");

            int [] nums = ArrayBuilder.GenerateIntArray(size);

            Console.WriteLine("Generated array: ");

            ArrayBuilder.WriteArray(nums);

            double arrayAverage = FindAverage(nums);

            Console.WriteLine($"Array average: {arrayAverage}");
        }

        static double FindAverage (int [] nums)
        {
            double sum = 0;

            foreach (int i in nums)
            {
                sum += i;
            }

            return sum / nums.Length;
        }
    }
}
