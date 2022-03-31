using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a static method that emulates the 
    /// Substring() method. The arguments to the static method are 
    /// text and two integer arguments. As a result, the method returns 
    /// a text string that consists of text characters (the first argument), 
    /// starting from the position with the index (the second argument). 
    /// The third argument to the static method specifies the number 
    /// of characters to include in the substring.
    /// </summary>
    internal class Ch7Task7
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            int from = InputChecker.EnterInteger("Enter \"from\" index: ");
            int count = InputChecker.EnterInteger("Enter length of substring: ");

            string substring = MySubstring(input, from, count);

            Console.WriteLine(substring);
        }

        static string MySubstring(string text, int from, int count)
        {
            StringBuilder sb = new StringBuilder();

            string result;
            try
            {
                for (int i = from; i < (from + count); i++)
                {
                    sb.Append(text[i]);
                }
                result = sb.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Out of input length!");
                result = "Input was incorrect!";
            }

            return result;
        }
    }
}
