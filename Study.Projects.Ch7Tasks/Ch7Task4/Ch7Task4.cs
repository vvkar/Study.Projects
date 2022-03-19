using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a static method that compares text strings. 
    /// Text strings are compared in the following way: for each text value, 
    /// a set of different letters is determined that are included in the text 
    /// (the number of occurrences of a letter in the text does not matter). 
    /// Text strings are considered equal if they contain the same set of letters.
    /// </summary>
    internal class Ch7Task4
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputOne = InputChecker.EnterString("Enter first string to compare: ");
                string inputTwo = InputChecker.EnterString("Enter second string to compare: ");

                if (StringsCompare(inputOne, inputTwo))
                {
                    Console.WriteLine("Strings are equal!");
                }
                else
                {
                    Console.WriteLine("Strings are not equal!");
                }
            }
        }

        static bool StringsCompare(string textOne, string textTwo)
        {
            List<char> chars = new List<char>();

            bool result = true;

            foreach(char c in textOne)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                }
            }
            foreach(char c in textTwo)
            {
                if (!chars.Contains(c))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
