using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task2
{
    internal class Ch3Task2
    {
        /// <summary>
        /// Write a program where user user enters two integers consecutively. 
        /// The program determines which of the numbers is greater than or equal to, 
        /// and displays a message. Use exception handling.
        /// </summary>
        public static void Main()
        {
            int firstNumber, secondNumber;
            do
            {
                Console.Write("Enter first integer number: ");

                string firstInput = Console.ReadLine();

                try
                {
                    firstNumber = int.Parse(firstInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter second integer number: ");

                string secondInput = Console.ReadLine();

                try
                {
                    secondNumber = int.Parse(secondInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
            while(true);

            if(firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater then {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{secondNumber} is greater then {firstNumber}");
            }
            else
            {
                Console.WriteLine("Your numbers are equal");
            }
        }
    }
}
