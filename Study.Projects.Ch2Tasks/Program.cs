using System;

class DialogDemo
{
    static void Main()
    {
        Console.Title = "Lets get aquanted";

        while (true)
        {
            Console.Write("Enter a number: ");
            var parseResult = Int32.TryParse(Console.ReadLine(), out int number);

            if (parseResult)
            {
                //var message = Checker.HowManyThousands(number);
                //Console.WriteLine(message); 

                Checker.Reverse2ndBit(number);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine();
        }
    }

    class Checker
    {
        //task 1 
        public static string CheckDivisionBy3(int number)
        {
            var message = (number % 3 == 0) ? "The number is divisible by 3"
                    : "The number is NOT divisible by 3";

            return message;
        }

        //task 1 alternative
        public static string CheckDivisionBy3New(int number)
        {
            /*
             The number could be divided by 3 if the summ of its numbers equals three
             */

            int summOfNumbers = 0;

            while (number > 0)
            {
                summOfNumbers += number % 10;
                number /= 10;
            }

            var message = (summOfNumbers % 3 == 0) ? "The number is divisible by 3"
                    : "The number is NOT divisible by 3";

            return message;
        }

        //task 2
        public static string CheckBy5And7(int number)
        {
            bool check = (number % 5 == 2) && (number % 7 == 1);

            var message = (check) ? "Acceptable"
                : "Unacceptable";

            return message;
        }

        //task 3
        public static string DivisableBy4MoreThen10(int number)
        {
            bool check = (number % 4 == 0) && (number > 10);

            var message = (check) ? "Acceptable"
                : "Unacceptable";

            return message;
        }

        //task 4
        public static string MoreThen5LessThen10(int number)
        {
            bool check = (number >= 5) && (number <= 10);

            return check.ToString();
        }

        //task 5 
        public static string HowManyThousands(int number)
        {
            int thousands = number / 1000 % 10;

            var message = $"There is {thousands} thousands in your number";

            return message;
        }

        //task 7
        /// <summary>
        /// Write a program that calculates the third bit from the right
        /// in the binary representation of the number entered by the user.
        /// The number is entered in decimal notation.
        /// Use the bitwise shift operator in your program.
        /// </summary>
        public static void ConvertToBinary(int number)
        {
            string binary = Convert.ToString(number, 2);

            var message = "Your number binary code: " + binary;

            Console.WriteLine(message);

            number >>= 2;

            binary = Convert.ToString(number, 2);

            var digit = binary[binary.Length - 1];

            message = "3rd right digit equals: " + digit;

            Console.WriteLine(message);
        }

        //task 8
        /// <summary>
        /// Write a program that changes the third bit from the right
        /// in the binary representation of the number entered by the user to one.
        /// </summary>
        public static void ConvertToBinaryAndSet3rdTo1(int number)
        {
            string binary = Convert.ToString(number, 2);

            binary = MinDigitsCheckAndFix(binary);

            var message = "Your number binary code: " + binary;

            Console.WriteLine(message);

            binary = binary.Remove(binary.Length - 3, 1).Insert(binary.Length - 3, "1");

            message = "Corrected binary code: " + binary;

            Console.WriteLine(message);

            var newNumber = Convert.ToInt32(binary, 2);

            message = "Your new number: " + newNumber;

            Console.WriteLine(message);
        }

        //task 9
        /// <summary>
        /// Write a program that changes the fourth bit from the right
        /// in the binary representation of the number entered by the user to zero.
        /// </summary>
        public static void ConvertToBinaryAndSet4thTo0(int number)
        {
            string binary = Convert.ToString(number, 2);

            binary = MinDigitsCheckAndFix(binary);

            var message = "Your number binary code: " + binary;

            Console.WriteLine(message);

            binary = binary.Remove(binary.Length - 4, 1).Insert(binary.Length - 4, "0");

            message = "Corrected binary code: " + binary;

            Console.WriteLine(message);

            var newNumber = Convert.ToInt32(binary, 2);

            message = "Your new number: " + newNumber;

            Console.WriteLine(message);
        }

        //task 10
        /// <summary>
        /// Write a program that changes the fourth bit from the right
        /// in the binary representation of the number entered by the user to zero.
        /// </summary>
        public static void Reverse2ndBit(int number)
        {
            string binary = Convert.ToString(number, 2);

            binary = MinDigitsCheckAndFix(binary);

            var message = "Your number binary code: " + binary;

            Console.WriteLine(message);

            binary = BitReverse(binary, 2);

            message = "Corrected binary code: " + binary;

            Console.WriteLine(message);

            var newNumber = Convert.ToInt32(binary, 2);

            message = "Your new number: " + newNumber;

            Console.WriteLine(message);
        }


        static string MinDigitsCheckAndFix(string binaryNumber)
        {
            if (binaryNumber.Length <= 3)
            {
                while (binaryNumber.Length <= 3)
                {
                    binaryNumber = binaryNumber.Insert(0, "0");
                }
            }
            return binaryNumber;
        }

        static string BitReverse(string binaryNumber, int bitNumber)
        {
            if (binaryNumber[binaryNumber.Length - bitNumber] == '0')
            {
                binaryNumber = binaryNumber.Remove(binaryNumber.Length - bitNumber, 1)
                    .Insert(binaryNumber.Length - bitNumber, "1");
            }
            else
            {
                binaryNumber = binaryNumber.Remove(binaryNumber.Length - bitNumber, 1)
                    .Insert(binaryNumber.Length - 2, "0");
            }
            return binaryNumber;
        }
    }
}