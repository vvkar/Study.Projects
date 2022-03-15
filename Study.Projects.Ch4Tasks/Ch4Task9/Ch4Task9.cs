using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates and initializes a two-dimensional numeric array. 
    /// Then the row and column are removed from the array. The index of the row and 
    /// column to be deleted determine using a random number generator.
    /// </summary>
    internal class Ch4Task9
    {
        static void Main(string[] args)
        {
            string rowsInput = InputChecker.InputEnter("Enter number of rows: ");

            int rows = InputChecker.MoreThenOneInputCheck(rowsInput);

            string colsInput = InputChecker.InputEnter("Enter number of cols: ");

            int cols = InputChecker.MoreThenOneInputCheck(colsInput);

            int [,] nums = new int[rows, cols];
            int [,] newNums = new int[rows - 1, cols - 1];

            Random rnd = new Random();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rnd.Next(1, 101);
                }
            }

            Console.WriteLine("Generated array: ");

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int rowToDel = rnd.Next(0, nums.GetLength(0));
            
            int colToDel = rnd.Next(0, nums.GetLength(1));

            Console.WriteLine($"Row to delete: {rowToDel + 1}\nCol to delete: {colToDel + 1}");

            for(int i = 0; i < nums.GetLength(0)-1; i++)
            {
                for(int j = 0; j < nums.GetLength(1)-1; j++)
                {
                    if(i >= rowToDel && j >= colToDel)
                    {
                        newNums[i, j] = nums[i + 1, j + 1];
                    }
                    else if (i >= rowToDel)
                    {
                        newNums[i, j] = nums[i + 1, j];
                    }
                    else if (j >= colToDel)
                    {
                        newNums[i, j] = nums[i, j + 1];
                    }
                    else
                    {
                        newNums[i, j] = nums[i, j];
                    }
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
