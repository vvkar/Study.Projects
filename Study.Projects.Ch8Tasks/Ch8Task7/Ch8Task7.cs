using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with a text field. 
    /// Describe operator methods in the class to perform type 
    /// casting. You need to define the following transformation methods. 
    /// When converting an object to an integer, the result returns 
    /// the number of characters in the text field value. When converting 
    /// an object to a character, the result is the first character in the text. 
    /// When converting a number to an object, an object is created (and returned 
    /// as a result) and its text field contains a text string of A characters. 
    /// The number of characters in the text is determined by the converted number.
    /// </summary>
    internal class Ch8Task7
    {
        static void Main(string[] args)
        {
            string text = InputChecker.EnterString();
            TaskClass obj = new TaskClass(text);

            Console.WriteLine($"\nObject created with a text field: \"{obj}\"");
            Console.WriteLine("\nObject to integer cast: " + (int)obj);
            Console.WriteLine("\nObject to char cast: " + (char)obj + "\n");

            int number = InputChecker.EnterInteger();
            TaskClass obj2 = number;

            Console.WriteLine($"\nObject created with a text field: \"{obj2}\"\n");
        }

        class TaskClass
        {
            readonly string text;

            public TaskClass(string text)
            {
                this.text = text;
            }

            public static implicit operator int (TaskClass obj)
            {
                return obj.text.Length;
            }

            public static implicit operator char (TaskClass obj)
            {
                return obj.text[0];
            }

            public static implicit operator TaskClass (int count)
            {
                String text = new String('A', count);
                return new TaskClass(text);
            }

            public override string ToString()
            {
                return this.text;
            }
        }
    }
}
