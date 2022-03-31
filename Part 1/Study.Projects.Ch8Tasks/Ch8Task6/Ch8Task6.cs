using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with an integer field. 
    /// Overload the &, |, true, and false operators so that 
    /// the && and || operators can be used with class objects. 
    /// The overload should be implemented so that an object 
    /// is considered "true" if its numeric field value is 2, 3, 5, or 7. 
    /// An object should be considered false if its numeric field 
    /// value is less than 1 or greater than 10.
    /// </summary>
    internal class Ch8Task6
    {
        static void Main(string[] args)
        {
            int numbOne = InputChecker.EnterInteger();
            TaskClass obj1 = new TaskClass(numbOne);

            int numTwo = InputChecker.EnterInteger();
            TaskClass obj2 = new TaskClass(numTwo);

            Console.WriteLine("\nObj1 && Obj2: " + (obj1 && obj2).TrueOrFalse());
            Console.WriteLine("\nObj1 || Obj2: " + (obj1 || obj2).TrueOrFalse());
        }

        class TaskClass
        {
            int number;

            public TaskClass(int number)
            {
                this.number = number;
                Console.WriteLine("Object created: " + number);
            }

            public static bool operator true (TaskClass obj)
            {
                switch (obj.number)
                {
                    case 2:
                    case 3:
                    case 5:
                    case 7:
                        return true;
                }
                return false;
            }

            public static bool operator false (TaskClass obj)
            {
                if((obj.number < 1) || (obj.number > 10))
                {
                    return true;
                }
                return false;
            }

            public static TaskClass operator & (TaskClass obj1, TaskClass obj2)
            {
                if (obj1) return obj2;
                else return obj1;
            }

            public static TaskClass operator | (TaskClass obj1, TaskClass obj2)
            {
                if (obj1) return obj1;
                else return obj2;
            }

            public string TrueOrFalse()
            {
                return this ? "True" : "False";
            }
        }
    }
}
