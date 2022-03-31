using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with two integer fields. 
    /// Describe operator methods for this class that allow you to compare 
    /// class objects for "less than" or "greater than". Assume that one object 
    /// is less/greater than another if the sum of the squares of its field values 
    /// is less than/greater than the sum of the squares of the field values of another object.
    /// </summary>
    internal class Ch8Task3
    {
        static void Main(string[] args)
        {
            int num1 = InputChecker.EnterInteger("Enter first number for first obj: ");
            int num2 = InputChecker.EnterInteger("Enter second number for first obj: ");

            TaskClass obj1 = new TaskClass(num1, num2);

            Console.WriteLine("First obj data: " + obj1);

            num1 = InputChecker.EnterInteger("Enter first number for second obj: ");
            num2 = InputChecker.EnterInteger("Enter second number for second obj: ");

            TaskClass obj2 = new TaskClass(num1, num2);

            Console.WriteLine("Second obj data: " + obj2);

            if (obj1 > obj2)
            {
                Console.WriteLine("Object1 > Object2!");
            }
            else if(obj1 < obj2)
            {
                Console.WriteLine("Object1 < Object2!");
            }
            else
            {
                Console.WriteLine("Object are equal!");
            }
        }

        class TaskClass
        {
            private int firstValue;
            private int secondValue;

            public TaskClass(int numberOne, int numberTwo)
            {
                firstValue = numberOne;
                secondValue = numberTwo;
            }

            public static bool operator > (TaskClass obj1, TaskClass obj2)
            {
                double sumOfSquares1 = Math.Pow(obj1.firstValue, 2) + Math.Pow(obj1.secondValue, 2);

                double sumOfSquares2 = Math.Pow(obj2.firstValue, 2) + Math.Pow(obj2.secondValue, 2);

                if(sumOfSquares1 > sumOfSquares2)
                {
                    return true;
                }
                return false;
            }

            public static bool operator < (TaskClass obj1, TaskClass obj2)
            {
                if(!(obj1 > obj2) && (obj1 != obj2))
                {
                    return true;
                }
                return false;
            }

            public static bool operator == (TaskClass obj1, TaskClass obj2)
            {
                double sumOfSquares1 = Math.Pow(obj1.firstValue, 2) + Math.Pow(obj1.secondValue, 2);

                double sumOfSquares2 = Math.Pow(obj2.firstValue, 2) + Math.Pow(obj2.secondValue, 2);

                if (sumOfSquares1 == sumOfSquares2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator != (TaskClass obj1, TaskClass obj2)
            {
                return !(obj1 == obj2);
            }

            public override string ToString()
            {
                return $"{firstValue}, {secondValue}";
            }
        }
    }
}
