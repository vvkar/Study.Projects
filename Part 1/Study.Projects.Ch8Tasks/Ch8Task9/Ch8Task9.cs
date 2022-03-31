using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with an integer field 
    /// and an overload of the +, -, and * operators. Suggest a way 
    /// to overload these operators so that the +=, -=, and *= operators 
    /// can be used with objects of the class.
    /// </summary>
    internal class Ch8Task9
    {
        static void Main(string[] args)
        {
            int numOne = InputChecker.EnterInteger();
            TaskClass obj1 = new TaskClass(numOne);
            Console.WriteLine("Object one created with number " + obj1);

            int numTwo = InputChecker.EnterInteger();
            TaskClass obj2 = new TaskClass(numTwo);
            Console.WriteLine("Object two created with number " + obj2);

            Console.WriteLine("Obj1 += obj2 => " + (obj1 += obj2));
            Console.WriteLine("Obj2 -= obj1 => " + (obj2 -= obj1));
            Console.WriteLine("Obj1 *= obj2 => " + (obj1 *= obj2));
        }

        class TaskClass
        {
            readonly int number;

            public TaskClass(int number)
            {
                this.number = number;
            }

            public static TaskClass operator + (TaskClass obj1, TaskClass obj2)
            {
                return new TaskClass(obj1.number + obj2.number);
            }

            public static TaskClass operator - (TaskClass obj1, TaskClass obj2)
            {
                return new TaskClass(obj1.number - obj2.number);
            }

            public static TaskClass operator * (TaskClass obj1, TaskClass obj2)
            {
                return new TaskClass(obj1.number * obj2.number);
            }

            public override string ToString()
            {
                return this.number.ToString();
            }
        }
    }
}
