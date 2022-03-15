using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program, where a one-dimensional numeric array 
    /// is created and filled with numbers that, when divided by 5, 
    /// give a remainder of 2. The size of the array is entered by the user. 
    /// Provide handling of an error associated with entering an invalid value.
    /// </summary>
    internal class Ch4Task1
    {
        static void Main()
        {
            string enterMessage = "Enter a number: ";

            string errorMessage = "Incorrect input!";

            string errorNegative = "Your input is negative!";

            string exitMessage = "Enter Q to exit the program.";

            while (true)
            {
                Console.Write(enterMessage);

                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                {
                    break;
                }

                int size;

                try
                {
                    size = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }

                if(size < 0)
                {
                    Console.WriteLine(errorNegative);
                    continue;
                }

                int[] nums = new int[size];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = 5 * i + 2;
                }

                foreach (int number in nums)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine("\n"+exitMessage);
            }
        }
    }
}
