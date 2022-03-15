using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates a two-dimensional array 
    /// of numbers and fills that array with a "snake": first the first row 
    /// (from left to right), the first column (from bottom to top), 
    /// the second row (from left to right), and so on.
    /// </summary>
    internal class Ch4Task10
    {
        static void Main(string[] args)
        {
            string rowsInput = InputChecker.InputEnter("Enter number of rows: ");

            int rows = InputChecker.MoreThenOneInputCheck(rowsInput);

            string colsInput = InputChecker.InputEnter("Enter number of cols: ");

            int cols = InputChecker.MoreThenOneInputCheck(colsInput);

            int[,] nums = new int[rows, cols];

            int number = 0;

            for (int currentRow = 0, currentCol = 0; currentRow < nums.GetLength(0);)
            {
                for (int j = currentCol; j < nums.GetLength(1); j++)
                {
                    nums[currentRow, j] = number++;
                }

                currentRow++;

                for(int i = currentRow; i < nums.GetLength(0); i++)
                {
                    nums[i, currentCol] = number++;
                }

                currentCol++;
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
        }
    }
}
