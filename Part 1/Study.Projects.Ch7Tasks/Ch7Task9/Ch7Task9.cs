using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a class that has a text field 
    /// and a character field. The value of the fields is assigned 
    /// by the constructor. The class must have a method returning 
    /// an array of text strings. These strings are obtained by splitting 
    /// the text field into substrings. The spliting indivator character 
    /// is the character argument. Override the ToString( ) method in the 
    /// class so that it returns the text with the value of the object's 
    /// fields and the substrings the text splited to.
    /// </summary>
    internal class Ch7Task9
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            char symb = InputChecker.EnterChar();

            Container container = new Container(input, symb);

            Console.WriteLine(container.ToString());
        }

        class Container
        {
            private string text;
            private char symb;

            public Container(string text, char symb)
            {
                this.text = text;
                this.symb = symb;
            }

            public string[] Split()
            {
                return text.Split(symb);
            }

            public override string ToString()
            {
                var subStrings = Split();
                StringBuilder sb = new StringBuilder();

                foreach (var substring in subStrings)
                {
                    sb.Append(substring + ", ");
                }
                string output = $"Text: {this.text}\nSymb: {this.symb}" + $"\n{sb.ToString().Trim(' ', ',')}";

                return output;
            }
        }
    }
}
