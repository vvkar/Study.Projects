using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program that describes a static method for 
    /// calculating the double factorial of a number passed 
    /// as an argument to this method. Suggest a variant 
    /// without recursion and with recursion.
    /// </summary>
    internal class Ch5Task1
    {
        static void Main(string[] args)
        {
            int num, result;

            do
            {
                num = InputChecker.EnterPositive();
            }
            while (!DoubleFact(num, out result));

            int recursiveResult = DoubleFactRecursive(num);

            Console.WriteLine(num + "!! = " + result);

            Console.WriteLine(num + "!! = " + recursiveResult + " - recursive");
        }

        static bool DoubleFact(int num, out int result)
        {
            result = 0;

            if (num < 3)
            {
                Console.WriteLine("Number should be 3 or more!");
                return false;
            }
            else
            {
                result = 1;

                for (int i = num; i > 0; i -= 2)
                {
                    result *= i;
                }
                return true;
            }
        }

        static int DoubleFactRecursive(int num)
        {
            if (num < 2)
            {
                return 1;
            }
            else
            {
                return num * DoubleFactRecursive(num - 2);
            }
        }
    }
}
