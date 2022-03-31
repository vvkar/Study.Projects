using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Study.Projects.Ch3Task5Simplified
{
    internal class Ch3Task5Simplified
    {
        public enum DaysOfWeekLowerCase
        {
            monday = 1,
            tuesday = 2,
            wednesday = 3,
            thursday = 4,
            friday = 5,
            saturday = 6,
            sunday = 7
        }

        public static void Main()
        {
            string enterMessage = "Enter the day of week: ";

            string errorMessage = "Incorrect input";

            string outputMessage = "The number of entered day: ";

            while (true)
            {
                Console.Write(enterMessage);

                string input = Console.ReadLine().ToLower();

                if(Enum.TryParse(input, out DaysOfWeekLowerCase day))
                {
                    Console.WriteLine(outputMessage + (int)day);
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}
