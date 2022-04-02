using System;

namespace Ch2Tasks
{
    public class InputChecker
    {
        static string errorMessage = "Incorrect input!";
        public string EnterString(string message)
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

        public string EnterString()
        {
            return EnterString("Enter any sentence: ");
        }

        public char EnterChar()
        {
            string enterMessage = "Enter any symbol: ";

            return EnterChar(enterMessage);
        }

        public char EnterChar(string message)
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

        public int EnterInteger()
        {
            string enterMessage = "Enter a number: ";

            return EnterInteger(enterMessage);
        }

        public int EnterIntegerMoreThenZero(string enterMessage)
        {
            int result;

            do
            {
                result = EnterInteger(enterMessage);
            }
            while (result <= 0);

            return result;
        }

        public int EnterIntegerMoreThenZero()
            => EnterIntegerMoreThenZero(enterMessage: "Enter a number more then zero: ");

        public int EnterInteger(string message)
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

        public int EnterNonNegativeInteger(string enterMessage)
        {
            int result;
            do
            {
                result = EnterInteger(enterMessage);
            }
            while (result <= 0);
            return result;
        }

        public int EnterNonNegativeInteger() =>
            EnterNonNegativeInteger(enterMessage: "Enter not negative integer: ");
    }
}
