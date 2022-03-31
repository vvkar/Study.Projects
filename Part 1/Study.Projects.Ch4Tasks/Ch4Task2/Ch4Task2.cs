using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates an array of 11 integers. 
    /// The array is filled with powers of two. When filling the array, 
    /// keep in mind that the initial element is equal to 1, 
    /// and each subsequent element is 2 times greater than the previous one. 
    /// Display the array in the console window in forward and reverse order. 
    /// The size of the array is given by a variable.
    /// </summary>
    internal class Ch4Task2
    {
        static void Main()
        {
            int size = 11;

            int [] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = (int)Math.Pow(2, i);
            }

            foreach(int num in nums)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine();

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + "\t");
            }

            Console.WriteLine();
        }
    }
}
