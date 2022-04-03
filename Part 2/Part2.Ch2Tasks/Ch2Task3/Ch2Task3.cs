using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that declares a delegate to handle methods 
    /// that take no argument and return a character result. Describe 
    /// a class that has a text field and a private field that is a reference 
    /// to a delegate instance. In the class, you need to describe a public 
    /// read-only property. The value of the property is the value of the 
    /// private field (that is, a reference to the delegate instance). 
    /// Describe a class constructor with two arguments: text (type string) 
    /// and boolean (type bool). The first text argument specifies the value 
    /// of the object's text field, and the second boolean argument specifies 
    /// the value of the private field of the delegate type. If the second 
    /// argument is true, then the value of the private field is set to an 
    /// anonymous method (or lambda expression) that returns the first character 
    /// from the text field as a result. If the boolean argument is false, 
    /// then the value of the private field is set to an anonymous method 
    /// (or lambda expression) that returns the result of the last character 
    /// from the text field. Create class objects and test the functionality 
    /// of the property: it can be called as a method, without arguments, 
    /// and the result is the first or last character in the text field 
    /// (depending on which boolean argument the object was created with).
    /// </summary>
    internal class Ch2Task3
    {
        static void Main(string[] args)
        {
            var checker = new InputChecker();
            string textOne = checker.EnterString("Enter text for the first object: ");
            TaskClass obj = new TaskClass(textOne, true);
            Console.WriteLine("First symbol is: " + obj.CheckSymb.Invoke());

            string textTwo = checker.EnterString("Enter text for the second object: ");
            obj = new TaskClass(textTwo, false);
            Console.WriteLine("Last symbol is: " + obj.CheckSymb.Invoke());
        }

        delegate char SymbChecker();

        class TaskClass
        {
            public string text;

            private SymbChecker _checkSymb;

            public SymbChecker CheckSymb { get => _checkSymb; }

            public TaskClass(string text, bool isFirst)
            {
                this.text = text;
                if (isFirst)
                {
                    _checkSymb = () => text[0];
                }
                else
                {
                    _checkSymb = () => text[text.Length - 1];
                }
            }
        }
    }
}
