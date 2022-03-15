using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates a two-dimensional array of integers. 
    /// It is filled with random numbers. Then swap rows and columns in this array.
    /// </summary>
    internal class Ch4Task8
    {
        static void Main(string[] args)
        {
            string rowsInput = InputChecker.InputEnter("Enter number of rows: ");

            int rows = InputChecker.PositiveIntInputCheck(rowsInput);

            string colsInput = InputChecker.InputEnter("Enter number of cols: ");

            int cols = InputChecker.PositiveIntInputCheck(colsInput);

            int[,] nums = new int[rows, cols];

            Random rnd = new Random();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rnd.Next(1, 101);
                }
            }

            Console.WriteLine("Generated array: ");

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Swapped array: ");

            int [,] newNums = new int[nums.GetLength(1), nums.GetLength(0)];

            for (int i = 0; i < newNums.GetLength(0); i++)
            {
                for( int j = 0; j < newNums.GetLength(1); j++)
                {
                    newNums[i, j] = nums[j, i];
                }
            }

            for(int i = 0; i < newNums.GetLength(0); i++)
            {
                for(int j = 0; j < newNums.GetLength(1); j++)
                {
                    Console.Write(newNums[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
