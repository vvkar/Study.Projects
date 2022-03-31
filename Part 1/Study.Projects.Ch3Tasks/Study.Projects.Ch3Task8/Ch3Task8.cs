using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task8
{
    /// <summary>
    /// Write a program that prints a sequence of Fibonacci numbers.
    /// </summary>
    internal class Ch3Task8
    {
        public static void Main()
        {
            string enterMessage = "Enter a number: ";

            string errorMessage = "Incorrect input!";

            Console.Write(enterMessage);

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int[] numbers = { 0, 1 };

                string resultMessage = $"The sum of {number} first Fibonacci numbers: ";

                for (int i = 0, sumOfTwo; i < number; i++)
                {
                    Console.Write($"{numbers[1]} ");

                    sumOfTwo = numbers.Sum();

                    numbers[0] = numbers[1];

                    numbers[1] = sumOfTwo;
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
