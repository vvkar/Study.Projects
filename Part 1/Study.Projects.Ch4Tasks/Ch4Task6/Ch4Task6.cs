using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates an array of integers, 
    /// fills it with random numbers, and then sorts the values 
    /// of the array's elements in numerical order.
    /// </summary>
    internal class Ch4Task6
    {
        static void Main(string[] args)
        {
            string input = InputChecker.InputEnter();

            int size = InputChecker.PositiveIntInputCheck(input);

            int [] nums = new int[size];

            Random random = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 101);
            }

            foreach(int i in nums)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            for(int i = 1; i < nums.Length; i++)
            {
                for (int k = 0, basket; k < nums.Length - 1; k++)
                {
                    if (nums[k] < nums[k + 1])
                    {
                        basket = nums[k];
                        nums[k] = nums[k + 1];
                        nums[k + 1] = basket;
                    }
                }
            }

            foreach (int i in nums)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();
        }
    }
}
