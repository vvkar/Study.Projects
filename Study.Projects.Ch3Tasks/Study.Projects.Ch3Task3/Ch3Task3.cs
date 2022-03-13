using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task3
{
    /// <summary>
    /// Write a program that calculates the sum of numbers entered by the user. 
    /// The program asks for a number, reads the number entered by the user, 
    /// adds it to the sum, and asks for the number again. 
    /// The process continues until the user enters an empty value. 
    /// Use exception handling.
    /// </summary>
    internal class Ch3Task3
    {
        static void Main()
        {
            int sum = 0;

            string enterMessage = "Enter a number to sum or press Enter to get a result: ";

            string errorMessage = "Incorrect input";

            string exitMessage = "The sum of numbers: ";

            do
            {
                Console.Write(enterMessage);

                string input = Console.ReadLine();

                try
                {
                    sum += int.Parse(input);
                }
                catch (FormatException)
                {
                    if(input == "")
                    {
                        break;
                    }
                    Console.WriteLine(errorMessage);
                }
            }
            while (true);

            Console.WriteLine(exitMessage + sum);
        }
    }
}
