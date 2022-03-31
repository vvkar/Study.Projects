using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    public class InputChecker
    {
        static string errorMessage = "Incorrect input!";

        public static char InputChar()
        {
            string enterMessage = "Enter any symbol: ";

            return InputChar(enterMessage);
        }

        public static char InputChar(string message)
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

        public static double EnterDouble(string message)
        {
            double result;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (!double.TryParse(input, out result))
                {
                    Console.WriteLine(errorMessage);
                }
            }
            while (!double.TryParse(input, out result));

            return result;
        }

        public static double EnterDouble()
        {
            string message = "Enter a real number: ";

            return EnterDouble(message);
        }
    }
}
