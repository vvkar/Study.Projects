using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that declares a delegate for methods with 
    /// two arguments (character and text) and an integer result. 
    /// In the main class, it is necessary to describe two static 
    /// methods. One static method returns the number of occurrences 
    /// of a character (first argument) in a text string (second argument) 
    /// as a result. Another method returns the index of the first occurrence 
    /// of the character (first argument) in the text string (second argument)
    /// as a result, or -1 if the character does not occur in the text string. 
    /// In the main method, create an instance of the delegate and use that 
    /// instance to call each of the static methods.
    /// </summary>
    internal class Ch2Task1
    {
        delegate int MyDelegate(char symb, string text);
        static void Main(string[] args)
        {
            var checker = new InputChecker();

            string text = checker.EnterString();
            char symbol = checker.EnterChar();

            MyDelegate myDelegate = GetNumOfOccurences;
            int numberOfOccurences = myDelegate.Invoke(symbol, text);
            Console.WriteLine($"Your symbol occurs in text {numberOfOccurences} times");

            myDelegate = GetIndexOfOccurence;
            int firstIndexOfSymbol = myDelegate.Invoke(symbol, text);
            Console.WriteLine($"Your symbol first index is {firstIndexOfSymbol}");
        }

        public static int GetNumOfOccurences(char symb, string text)
        {
            int occurences = 0;
            foreach (char c in text)
            {
                if (c == symb)
                {
                    occurences++;
                }
            }
            return occurences;
        }

        public static int GetIndexOfOccurence(char symb, string text)
        {
            return text.IndexOf(symb);
        }
    }
}
