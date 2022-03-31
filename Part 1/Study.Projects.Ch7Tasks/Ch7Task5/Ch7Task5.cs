using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a static method that determines the positions 
    /// of a certain character in the text. The arguments to the method are 
    /// text and a character. As a result, method returns an integer array 
    /// with indices of the positions where the character (the second argument) 
    /// is located in the text (the first argument). If the character is not 
    /// found in the text, method returns an array of one element equal to -1.
    /// </summary>
    internal class Ch7Task5
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            char symb = InputChecker.EnterChar();

            var result = CharSearch(input, symb);

            Console.Write("Indexes of symbol in entered text: ");

            foreach(int index in result)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }

        static int[] CharSearch(string text, char symb)
        {
            List <int> indexs = new List <int>();

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == symb)
                {
                    indexs.Add(i);
                }
            }
            if (!text.Contains(symb))
            {
                indexs.Add(-1);
            }
            return indexs.ToArray();
        }
    }
}
