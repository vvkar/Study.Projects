using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Task5
{
    /// <summary>
    /// Write a program that creates an array and fills it with random numbers. 
    /// The array is displayed in the console. In this array, you need to determine 
    /// the element with the minimum value. In particular, 
    /// the program should output the value of the element with the minimum value 
    /// and the index of that element. If there are multiple elements, the indexes 
    /// of all those elements should be printed.
    /// </summary>
    internal class Ch4Task5
    {
        static void Main(string[] args)
        {
            string input = InputChecker.InputEnter();

            int size = InputChecker.PositiveIntInputCheck(input);

            Random random = new Random();

            int [] nums = new int[size];

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 101);
            }

            foreach(int i in nums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int minNum = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < minNum)
                {
                    minNum = nums[i];
                }
            }

            for(int i = 0, count = 0; i < nums.Length; i++)
            {
                if(nums[i] == minNum)
                {
                    if(count > 0)
                    {
                        sb.Append(", ");
                    }

                    sb.Append(i);
                    count++;
                }
            }

            string minIndex = sb.ToString();

            Console.WriteLine($"Min number: {minNum} \nIt's index: {minIndex}");
        }
    }
}
