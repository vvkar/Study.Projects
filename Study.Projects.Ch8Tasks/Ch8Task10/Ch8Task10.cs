using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with a character field 
    /// and an overload of the + and - operators. The operators 
    /// must be overloaded so that applying the + operator to 
    /// objects of the class results in text, which is the result 
    /// of the concatenation of the character fields of the summed 
    /// objects. When applying the - operator to objects of a class, 
    /// the result must be an integer (the difference in character 
    /// codes from the objects being subtracted). Suggest ways to 
    /// overload cast operators so that the += and -= operators 
    /// can be used with class objects.
    /// </summary>
    internal class Ch8Task10
    {
        static void Main(string[] args)
        {
            char symbOne = InputChecker.EnterChar();
            TaskClass obj1 = new TaskClass(symbOne);
            Console.WriteLine("Object one created with symb: " + obj1);

            char symbTwo = InputChecker.EnterChar();
            TaskClass obj2 = new TaskClass(symbTwo);
            Console.WriteLine("Object two created with symb: " + obj2);

            Console.WriteLine("Obj1 + Obj2 = " + (obj1 + obj2));
            Console.WriteLine("Obj1 - Obj2 = " + (obj1 - obj2));

            int number = InputChecker.EnterInteger();

            Console.WriteLine($"Obj1 += {number} => {obj1 += number}");
            Console.WriteLine($"Obj1 -= {number} => {obj2 -= number}");
        }

        class TaskClass
        {
            readonly char symb;

            public TaskClass(char symb)
            {
                this.symb = symb;
            }

            public TaskClass(int symbIndex)
            {
                this.symb = (char)symbIndex;
            }

            public static string operator + (TaskClass obj1, TaskClass obj2)
            {
                return obj1.symb.ToString() + obj2.symb.ToString();
            }

            public static int operator - (TaskClass obj1, TaskClass obj2)
            {
                return obj1.symb - obj2.symb;
            }

            public static TaskClass operator + (TaskClass obj1, int number)
            {
                return new TaskClass(obj1.symb + number);
            }

            public static TaskClass operator - (TaskClass obj1, int number)
            {
                return new TaskClass(obj1.symb - number);
            }

            public override string ToString()
            {
                return this.symb.ToString();
            }
        }
    }
}
