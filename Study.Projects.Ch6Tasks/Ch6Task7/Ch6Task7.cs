using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has two fields: 
    /// character and text. The class must have an overloaded method 
    /// for assigning values ​​to fields. If the method is called with 
    /// a character argument, the corresponding value is assigned 
    /// to the character field. If the method is called with a text argument, 
    /// then it determines the value of the text field. A character array 
    /// can also be passed as an argument to the method. If the array has 
    /// one element. then it defines the value of the character field. 
    /// Otherwise (if there is more than one element), a text string 
    /// is formed from the array character and assigned a value to the text field.
    /// </summary>
    internal class Ch6Task7
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            Console.Write("Enter anything: ");
            string input = Console.ReadLine();

            obj.Set(input);
            obj.PrintInfo();

            char symb = InputChecker.InputChar();

            obj.Set(symb);
            obj.PrintInfo();

            Console.Write("Enter anything again: ");
            input = Console.ReadLine();

            obj.Set(input.ToCharArray());
            obj.PrintInfo();
        }

        class MyClass
        {
            private char symb;
            private string txt;

            public void Set (char symb)
            {
                this.symb = symb;
            }

            public void Set (string txt)
            {
                this.txt = txt;
            }

            public void Set (char [] array)
            {
                if (array.Length > 1)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in array)
                    {
                        sb.Append(c);
                    }
                    Set(sb.ToString());
                }
                else if(array.Length == 0)
                {
                    Console.WriteLine("Incorrect input!");
                }
                else
                {
                    Set(array[0]);
                }
            }

            public void PrintInfo()
            {
                if(this.txt != null && this.symb != '\0')
                {
                    Console.WriteLine("Text in object: " + this.txt);
                    Console.WriteLine("Symb in object: " + this.symb);
                }
                else if(this.txt != null)
                {
                    Console.WriteLine("Text in object: " + this.txt);
                }
                else if(this.symb != '\0')
                {
                    Console.WriteLine("Symb in object: " + this.symb);
                }
                else
                {
                    Console.WriteLine("The object is empty!");
                }
            }
        }
    }
}
