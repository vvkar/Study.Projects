using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that calculates 
    /// the sum of square natural numbers. The number n is passed 
    /// as an argument to the method. Suggest a variant 
    /// of the method with and without recursion.
    /// </summary>
    internal class Ch5Task2
    {
        static void Main(string[] args)
        {
            int num = InputChecker.EnterPositive();

            int result = SumOfSquares(num);

            Console.WriteLine($"Sum of squares of {num} first integers: {result}");

            int reversedResult = SumOfSquaresReversed(num);

            Console.WriteLine($"Reversed method result: {reversedResult}");
        }

        static int SumOfSquares (int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        static int SumOfSquaresReversed(int num)
        {
            if(num < 1)
            {
                return 0;
            }
            return num*num + SumOfSquaresReversed(num - 1);
        }
    }
}
