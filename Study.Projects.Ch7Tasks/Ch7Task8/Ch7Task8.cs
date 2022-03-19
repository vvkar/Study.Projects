using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Tasks
{
    /// <summary>
    /// Write a program with a class that has a text field. 
    /// The value of the text field is assigned when the class 
    /// object is created. Also, the class should have a method 
    /// that allows you to insert a substring into the text from 
    /// the text field. The substring to be inserted into the text 
    /// is passed as arguments to the method, as well as the index 
    /// of the position from which the insertion is performed. 
    /// Redefine the ToString( ) method in the class so that it 
    /// returns the value of the text from the text field.
    /// </summary>
    internal class Ch7Task8
    {
        static void Main(string[] args)
        {
            string input = InputChecker.EnterString();

            TextContainer obj = new TextContainer(input);

            string substring = InputChecker.EnterString("Enter substring to insert: ");
            int index = InputChecker.EnterInteger("Enter index where to place substring: ");

            obj.SetSubstring(substring, index);

            Console.WriteLine("Final result: " + obj.ToString());
        }
    }

    class TextContainer
    {
        private string text;

        public TextContainer(string text)
        {
            SetText(text);
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetSubstring(string substring, int index)
        {
            List <string> list = new List <string>();

            StringBuilder sb = new StringBuilder();
            try
            {
                for (int i = 0; i < index; i++)
                {
                    sb.Append(this.text[i]);
                }
                sb.Append(substring);
                for (int i = index; i < this.text.Length; i++)
                {
                    sb.Append(this.text[i]);
                }
                this.text = sb.ToString();
            }
            catch
            {
                Console.WriteLine("Wrong index input!");
            }
        }

        public override string ToString()
        {
            return this.text;
        }
    }
}
