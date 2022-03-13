using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task7
{
    /// <summary>
    /// Write a program to calculate the sum of squares of natural numbers.
    /// </summary>
    internal class Ch3Task7
    {
        public static void Main()
        {
            string enterMessage = "Enter a number: ";

            string errorMessage = "Incorrect input!";

            Console.Write(enterMessage);

            string input = Console.ReadLine();

            if(int.TryParse(input, out int number))
            {
                int sum = 0;

                string resultMessage = $"The sum of squares of {number} first natural numbers: ";

                while(number > 0)
                {
                    sum += (int)Math.Pow(number, 2);
                    number--;
                }

                Console.WriteLine(resultMessage + sum);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
