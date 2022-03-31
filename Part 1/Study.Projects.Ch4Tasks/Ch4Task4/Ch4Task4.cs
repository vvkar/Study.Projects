using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Tasks
{
    /// <summary>
    /// Write a program that creates a character array with 10 elements. 
    /// Fill the array with capital letters of the English alphabet, but only consonants.
    /// </summary>
    internal class Ch4Task4
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y' };

            int size = 10;

            char[] consonants = new char[size];

            char letter = 'B';

            for (int i = 0; i < consonants.Length; i++, letter++)
            {
                while (true)
                {
                    if(vowels.Any(x => x == letter))
                    {
                        letter++;
                    }
                    else
                    {
                        consonants[i] = letter;
                        break;
                    }
                }
            }
            
            foreach (char c in consonants)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}
