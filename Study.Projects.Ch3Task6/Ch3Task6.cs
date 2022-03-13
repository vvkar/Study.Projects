using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task6
{
    /// <summary>
    /// Write a program that calculates the sum of odd numbers.
    /// </summary>
    internal class Ch3Task6
    {
        public static void Main()
        {

            string enterMessage = "Enter a number: ";

            string errorMessage = "Incorrect input!";

            while (true)
            {
                Console.Write(enterMessage);

                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    int sum = 0;
                    for(int i = 0; i < number; i++)
                    {
                        sum += 2 * i + 1;
                    }

                    string outputMessage = $"The sum of {number} first odd numbers: ";

                    Console.WriteLine(outputMessage + sum);
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}
