using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with an integer field 
    /// and a character field. Overload the "true" and "false" 
    /// operators so that "true" is an object whose difference 
    /// between the value of an integer field and a character code 
    /// from a character field does not exceed 10. Use an object 
    /// of this class (as a condition in a conditional operator) 
    /// to to display a sequence of characters in a console window.
    /// </summary>
    internal class Ch8Task5
    {
        static void Main(string[] args)
        {
            int number = InputChecker.EnterInteger();
            char symbol = InputChecker.EnterChar();

            TaskClass obj = new TaskClass(number, symbol);

            int changeNumber = -1;

            if(obj.number > obj.symbol)
            {
                changeNumber = 1;
            }

            do
            {
                Console.WriteLine($"{obj.symbol}");
                obj.symbol = (char)(obj.symbol + changeNumber);
            }
            while (obj);
        }

        class TaskClass
        {
            public int number;
            public char symbol;

            public TaskClass(int number, char symbol)
            {
                this.number = number;
                this.symbol = symbol;
                Console.WriteLine("Created object info: " + this);
            }

            public static bool operator true(TaskClass obj)
            {
                if ((obj.number - (int)obj.symbol <= 10))
                {
                    return true;
                }
                return false;
            }

            public static bool operator false(TaskClass obj)
            {
                return obj ? false : true;
            }

            public override string ToString()
            {
                return $"symbol: \'{this.symbol}\', number = {this.number}";
            }
        }
    }
}
