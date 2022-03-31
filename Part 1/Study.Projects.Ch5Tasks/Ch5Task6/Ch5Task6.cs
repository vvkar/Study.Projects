using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes a 
    /// two-dimensional array of integers as an argument. 
    /// The method, in addition to the array argument, 
    /// has two uninitialized arguments. As a result, 
    /// the method returns the value of the largest array element. 
    /// Uninitialized arguments are assigned element index values.
    /// </summary>
    internal class Ch5Task6
    {
        static void Main(string[] args)
        {
            int rows = InputChecker.EnterPositive("Enter a number of rows: ");

            int cols = InputChecker.EnterPositive("Enter a number of cols: ");

            int [,] array = ArrayBuilder.Generate2DimIntArray(rows, cols);

            Console.WriteLine("Generated array: ");

            ArrayBuilder.WriteArray(array);

            int maxNum = FindMax(array, out int maxRow, out int maxCol);

            Console.WriteLine($"Maximum element - {maxNum}");
            Console.WriteLine($"Max element index - ({maxRow+1}, {maxCol+1})");
        }

        static int FindMax(int [,] array, out int row, out int col)
        {
            int max = array[0, 0];
            row = 0; 
            col = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] > max)
                    {
                        max = array[i, j];
                        col = j;
                        row = i;
                    }
                }
            }
            return max;
        }
    }
}
