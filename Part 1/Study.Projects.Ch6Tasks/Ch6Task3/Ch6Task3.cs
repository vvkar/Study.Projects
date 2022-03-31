using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has two integer fields. 
    /// The class must contain constructors that allow you to create 
    /// objects without passing arguments, passing one argument, 
    /// and passing two arguments.
    /// </summary>
    internal class Ch6Task3
    {
        static void Main(string[] args)
        {
            int firstObjCheck1 = InputChecker.EnterInteger("Enter first number: ");
            int firstObjCheck2 = InputChecker.EnterInteger("Enter second number: ");

            MyClass obj1 = new MyClass(firstObjCheck1, firstObjCheck2);

            int secondObjCheck1 = InputChecker.EnterInteger("\nEnter only one number: ");

            MyClass obj2 = new MyClass(secondObjCheck1);

            MyClass obj3 = new MyClass();

            Console.WriteLine();

            Console.WriteLine($"First object: {obj1.firstNumber} {obj1.secondNumber}\n");
            Console.WriteLine($"Second object: {obj2.firstNumber} {obj2.secondNumber}\n");
            Console.WriteLine($"Third object: {obj3.firstNumber} {obj3.secondNumber}\n");
        }

        class MyClass
        {
            public int firstNumber;
            public int secondNumber;

            public MyClass(int firstNumber, int secondNumber)
            {
                this.firstNumber = firstNumber;
                this.secondNumber = secondNumber;
            }
            public MyClass(int firstNumber) : this(firstNumber, 0)
            {
            }
            public MyClass() : this(0, 0)
            {

            }
        }
    }
}
