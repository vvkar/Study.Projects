using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a static method to compare text strings. 
    /// Strings are compared character by character for a match. 
    /// The rule for comparing characters is: two characters are 
    /// considered the same if their codes differ by no more than one. 
    /// Text strings match if they have the same characters (in the sense above).
    /// </summary>
    internal class Ch7Task3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputOne = InputChecker.EnterString("Enter first sentence to check: ");
                string inputTwo = InputChecker.EnterString("Enter second sentence to check: ");

                if(StringComparison(inputOne, inputTwo))
                {
                    Console.WriteLine("Sentences are equal!");
                }
                else
                {
                    Console.WriteLine("Sentences are not equal!");
                }
            }
        }

        static bool StringComparison(string textOne, string textTwo)
        {
            bool result = true;
            for(int i = 0; i < textOne.Length; i++)
            {
                if(textOne[i] - textTwo[i] > 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
