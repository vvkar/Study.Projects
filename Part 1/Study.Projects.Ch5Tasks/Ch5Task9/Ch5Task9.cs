using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes an arbitrary number 
    /// of integer arguments as an argument. As a result, the method returns 
    /// an array of two elements: these are the values ​​of the largest and smallest 
    /// values ​​among the arguments passed to the method.
    /// </summary>
    internal class Ch5Task9
    {
        static void Main(string[] args)
        {
            int firstNumber = InputChecker.EnterInteger("Enter first number: ");
            int secondNumber = InputChecker.EnterInteger("Enter second number: ");
            int thirdNumber = InputChecker.EnterInteger("Enter third number: ");
            int fourthNumber = InputChecker.EnterInteger("Enter fourth number: ");
            int fifthNumber = InputChecker.EnterInteger("Enter fifth number: ");

            int [] result = FindMinMax(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

            Console.WriteLine($"Minimum number: {result[0]}");

            Console.WriteLine($"Maximum number: {result[1]}");
        }

        static int[] FindMinMax (params int[] args)
        {
            int min = args[0];
            int max = args[1];

            for(int i = 0; i < args.Length; i++)
            {
                if (args[i] < min)
                {
                    min = args[i];
                }
                else if(args[i] > max)
                {
                    max = args[i];
                }
            }
            return new int[] { min, max };
        }
    }
}
