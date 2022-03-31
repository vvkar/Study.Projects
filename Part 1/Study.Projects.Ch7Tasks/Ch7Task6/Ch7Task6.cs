using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a static method with the text 
    /// argument passed, and a result as a character array 
    /// consisting of letters (excluding spaces and punctuation marks) 
    /// that make up the entered text. If a letter occurs several times 
    /// in the text, it must be represented by a single element in the array. 
    /// The letters in the result array must be sorted alphabetically.
    /// </summary>
    internal class Ch7Task6
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            Console.Write("Letters of string: ");

            var result = GetSymbs(input);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static char[] GetSymbs(string text)
        {
            List<char> symbs = new List<char>();
            foreach (char c in text)
            {
                if (!symbs.Contains(c) && ((c > 'A' && c < 'Z') || (c > 'a' && c < 'z')))
                {
                    symbs.Add(c);
                }
            }
            var array = symbs.ToArray();

            char basket;

            for(int n = 0; n < array.Length; n++) 
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        basket = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = basket;
                    }
                }
            }

            return array;
        }
    }
}
