using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program that has a static method that returns 
    /// a text value as a result and receives text as an argument. 
    /// The result of the method is the text passed as the argument, 
    /// in which the words appear in reverse order. Words are
    /// blocks of text separated by spaces.
    /// </summary>
    internal class Ch7Task2
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            Console.WriteLine(TextReverse(input));
        }

        static string TextReverse(string input)
        {
            string [] words = input.Split(' ');

            StringBuilder sb = new StringBuilder();

            for(int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i] + " ");
            }

            return sb.ToString().Trim();
        }
    }
}
