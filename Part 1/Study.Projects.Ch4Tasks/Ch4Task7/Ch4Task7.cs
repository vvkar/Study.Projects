using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates an array of characters 
    /// and then reverses the order of the elements in the array.
    /// </summary>
    internal class Ch4Task7
    {
        static void Main(string[] args)
        {
            string input = InputChecker.InputEnter();

            int size = InputChecker.PositiveIntInputCheck(input);

            char [] chars = new char[size];

            Random random = new Random();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)random.Next((int)'A', (int)'z' + 1);
            }

            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            char [] reversedChars = new char[size];

            for (int i = 0; i < chars.Length; i++)
            {
                reversedChars[i] = chars[(chars.Length - 1) - i];
            }

            foreach(char c in reversedChars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}
