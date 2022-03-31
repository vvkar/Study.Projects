using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Projects.Ch3Task5
{
    /// <summary>
    /// Write a program that asks user to enter the name of the day of the week. 
    /// According to the entered name, the program determines the ordinal number of the day of the week. 
    /// If the user enters an invalid day name, the program displays a message stating that there is no such day. 
    /// Suggest a version of the program based on nested conditional statements and based on the switch statement.
    /// </summary>
    internal class Ch3Task5
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

        public static void Main()
        {
            string enterMessage = "Enter the day of week: ";

            string errorMessage = "Incorrect input";

            while (true)
            {
                Console.Write(enterMessage);

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "monday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Monday);
                            break;
                        }
                    case "tuesday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Tuesday);
                            break;
                        }
                    case "wednesday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Wednesday);
                            break;
                        }
                    case "thursday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Thursday);
                            break;
                        }
                    case "friday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Friday);
                            break;
                        }
                    case "saturday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Saturday);
                            break;
                        }
                    case "sunday":
                        {
                            Console.WriteLine((int)DaysOfWeek.Sunday);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(errorMessage);
                            continue;
                        }
                }
                break;            
            }
        }
    }
}
