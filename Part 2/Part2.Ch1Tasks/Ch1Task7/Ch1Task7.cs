using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program where a class is created based on 
    /// two interfaces. The first interface has an integer 
    /// property that is readable and writable. The second 
    /// interface has a text property available for reading 
    /// and writing. In each of the interfaces, the same 
    /// (with the same names) methods are declared, without
    /// arguments, and not returning a result. In the class, 
    /// describe the corresponding method that displays the 
    /// property values in the console window.
    /// </summary>
    internal class Ch1Task7
    {
        static void Main(string[] args)
        {
            InputChecker checker = new InputChecker();

            int number = checker.EnterInteger();
            string text = checker.EnterString();
            var taskObj = new TaskClass(number, text);

            taskObj.PrintInfo();
        }

        class TaskClass : IIntProperty, IStringProperty
        {
            public int Number { get; set; }
            public string Text { get; set; }

            public TaskClass(int number, string text)
            {
                Number = number;
                Text = text;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{nameof(Number)} property = {Number}");
                Console.WriteLine($"{nameof(Text)} property: \"{Text}\"");
            }
        }

        interface IIntProperty
        {
            int Number { get; set; }
            void PrintInfo();
        }

        interface IStringProperty
        {
            string Text { get; set; }
            void PrintInfo();
        }
    }
}
