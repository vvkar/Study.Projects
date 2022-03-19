﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    public class InputChecker
    {
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
    }
}
