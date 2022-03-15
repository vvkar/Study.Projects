using System;

namespace Ch4Tasks
{
    public class InputChecker
    {
        /// <summary>
        /// Displays an input message and accepts the value that the user has entered.
        /// </summary>
        /// <returns>A string with users input data.</returns>
        public static string InputEnter()
        {
            string enterMessage = "Enter a number: ";

            Console.Write(enterMessage);

            return Console.ReadLine();
        }
        public static string InputEnter(string message)
        {
            Console.Write(message);

            return Console.ReadLine();
        }
        /// <summary>
        /// Tests a string value for integer and non-negativity.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns an integer from input.</returns>
        public static int PositiveIntInputCheck(string input)
        {
            string errorMessage = "Incorrect input!";

            string negativeInput = "Your input is negative!";

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine(errorMessage);

                result = PositiveIntInputCheck(InputEnter());
            }
            else if (result < 0)
            {
                Console.WriteLine(negativeInput);

                result = PositiveIntInputCheck(InputEnter());
            };
            return result;
        }

        public static int MoreThenOneInputCheck(string input)
        {
            string moreThenOneError = "Your number shoul be more then one!";
            
            int result = PositiveIntInputCheck(input);
            
            if(result <= 1)
            {
                Console.WriteLine(moreThenOneError);
                result = MoreThenOneInputCheck(InputEnter());
            }
            return result;
        }
    }
}
