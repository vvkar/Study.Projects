using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with an overloaded static method. 
    /// If two integers are passed as an argument to the method, 
    /// then the result returns a reference to an integer array 
    /// consisting of natural numbers, and the first and last number 
    /// in this array are determined by the method arguments. 
    /// If two character values ​​are passed as an arguments to the method, 
    /// then the result returns a reference to an array consisting 
    /// of a sequence of characters, and the first and last characters 
    /// are determined by the method arguments.
    /// </summary>
    internal class Ch5Task8
    {
        static void Main(string[] args)
        {
            string enterMessage = "Enter first integer or character: ";

            string enter2ndNumberMessage = "Enter a second number: ";

            string charNumberError = "Your input must be ONLY ONE character!";

            string enter2ndCharMessage = "Enter a second character: ";

            string equalsError = "Your inputs should be different!";

            string firstInput, secondInput;

            int firstNumber, secondNumber;

            char firstChar, secondChar;

            while (true)
            {
                Console.Write(enterMessage);

                firstInput = Console.ReadLine();

                if (int.TryParse(firstInput, out  firstNumber))
                {
                    do
                    {
                        Console.Write(enter2ndNumberMessage);
                        secondInput = Console.ReadLine();
                        if(secondInput == firstInput)
                        {
                            Console.WriteLine(equalsError);
                            continue;
                        }
                    }
                    while (!int.TryParse(secondInput, out secondNumber));

                    Console.WriteLine("Generated integer array: ");

                    GenerateArray(firstNumber, secondNumber, out int[] array);

                    ArrayBuilder.WriteArray(array);

                    break;
                }
                else if (firstInput.Length > 1)
                {
                    Console.WriteLine(charNumberError);
                }
                else
                {
                    do
                    {
                        Console.Write(enter2ndCharMessage);
                        secondInput = Console.ReadLine();
                        if (firstInput == secondInput)
                        {
                            Console.WriteLine(equalsError);
                            secondInput = "";
                        }
                    }
                    while (secondInput.Length > 1 || secondInput.Length == 0);

                    firstChar = firstInput.ToCharArray()[0];

                    secondChar = secondInput.ToCharArray()[0];

                    Console.WriteLine("Generated character array: ");

                    GenerateArray(firstChar, secondChar, out char[] array);

                    ArrayBuilder.WriteArray(array);

                    break;
                }
            }
        }

        static void GenerateArray(int firstNumber, int secondNumber, out int[] array)
        {
            array =  ArrayBuilder.FromToIntArrayGenerate(firstNumber, secondNumber);
        }

        static void GenerateArray (char firstChar, char secondChar, out char[] array)
        {
            array = ArrayBuilder.FromToCharArrayGenerate(firstChar, secondChar);
        }
    }
}
