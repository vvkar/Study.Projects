using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Task3
{
    /// <summary>
    /// Write a program that creates a character array with 10 elements. 
    /// The array is filled with letters "one at a time", starting with the letter "a". 
    /// Display the array in the console window in forward and reverse order. 
    /// The size of the array is given by a variable.
    /// </summary>
    internal class Ch4Task3
    {
        static void Main(string[] args)
        {
            int size = 10;

            char[] chars = new char[size];

            chars [0] = 'a';
            
            for(int i = 1; i < size; i++)
            {
                chars [i] = (char)(chars[i-1]+2);
            }

            foreach(char c in chars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            for(int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars [i] + " ");
            }

            Console.WriteLine ();
        }
    }
}
