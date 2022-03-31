using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task9
{
    /// <summary>
    /// Write a program where user enters two integers. 
    /// The program displays all integers, starting with the smallest 
    /// (of the two entered numbers) and ending with the largest.
    /// </summary>
    internal class Ch3Task9
    {
        public static void Main()
        {
            string errorMessage = "Incorrect input!";

            int firstNumber, secondNumber;

            while (true)
            {
                Console.Write("Enter first number: ");

                string firstInput = Console.ReadLine();

                if(int.TryParse(firstInput, out firstNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }

            while (true)
            {
                Console.Write("Enter second number: ");

                string secondInput = Console.ReadLine();

                if (int.TryParse(secondInput, out secondNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }

            if (firstNumber > secondNumber)
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (secondNumber > firstNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
