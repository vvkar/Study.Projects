using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Project.Ch3Task4
{
    /// <summary>
    /// Write a program where user enters an integer in the range from 1 to 7, 
    /// and the program determines the day of the week from this number. 
    /// If the number is out of range, display a message that the entered value is invalid. 
    /// Suggest a mechanism for handling an error associated with entering a non-numeric value.
    /// </summary>
    internal class Ch3Task4Simplified
    {
        public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main()
        {
            string inputMessage = "Enter integer to determine the day of week: ";

            string errorFormat = "Incorrect input!";

            string errorRange = "Your input is out of range!";

            while (true)
            {
                Console.Write(inputMessage);

                string input = Console.ReadLine();

                int number;

                try
                {
                    number = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine(errorFormat);
                    continue;
                }

                if ((number >= 1) && (number <= 7))
                {
                    Console.WriteLine((DaysOfWeek)number);
                }
                else
                {
                    Console.WriteLine(errorRange);
                    continue;
                }

                break;
            }
        }
    }
}
