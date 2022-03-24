using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    public class InputChecker
    {
        static string errorMessage = "Incorrect input!";
        public static string EnterString(string message)
        {
            string inputLengthError = "Your input is too short!";
            string input;

            do
            {
                Console.Write(message);


                input = Console.ReadLine();

                if (input.Length < 1)
                {
                    Console.WriteLine(inputLengthError);
                }
            }
            while (input.Length < 1);

            return input;
        }

        public static string EnterString()
        {
            return EnterString("Enter any sentence: ");
        }

        public static char EnterChar()
        {
            string enterMessage = "Enter any symbol: ";

            return EnterChar(enterMessage);
        }

        public static char EnterChar(string message)
        {
            string quantityError = "You input sould consist of only one symbol!";
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (input.Length > 1 || input.Length == 0)
                {
                    Console.WriteLine(quantityError);
                }
            }
            while (input.Length > 1 || input.Length == 0);

            return input[0];
        }

        public static int EnterInteger()
        {
            string enterMessage = "Enter a number: ";

            return EnterInteger(enterMessage);
        }

        public static int EnterInteger(string message)
        {
            int result;
            string input;

            while (true)
            {
                Console.Write(message);

                input = Console.ReadLine();

                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine(errorMessage);
                }
                else break;
            }
            return result;
        }
    }
}
