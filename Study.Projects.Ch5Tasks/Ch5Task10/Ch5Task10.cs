using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that is 
    /// passed text and an arbitrary number of symbolic arguments. 
    /// The result returns the text that is obtained by appending 
    /// to the end of the source text (the first argument of the method) 
    /// the character values ​​passed as arguments to the method.

    /// </summary>
    internal class Ch5Task10
    {
        static void Main(string[] args)
        {
            Console.Write("Write a sentence: ");
            string input = Console.ReadLine();

            Console.Write("Enter first character to append: ");
            char firstChar = Console.ReadLine()[0];

            Console.Write("Enter second character to append: ");
            char secondChar = Console.ReadLine()[0];

            Console.Write("Enter third character to append: ");
            char thirdChar = Console.ReadLine()[0];

            string output = TextAppend(input, firstChar, secondChar, thirdChar);

            Console.WriteLine(output);
        }

        static string TextAppend (string text, params char[] chars)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(text);

            foreach (char c in chars)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
