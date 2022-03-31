using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program that has a static method. A text value 
    /// is passed as an argument to the method. As a result, 
    /// the method returns the text where spaces are inserted between characters.
    /// </summary>
    internal class Ch7Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any sentecne: ");
            string input = Console.ReadLine();

            Console.WriteLine(SpaceInsert(input));
            
        }

        static string SpaceInsert(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                sb.Append(c +" ");
            }
            return sb.ToString().Trim();
        }
    }
}
