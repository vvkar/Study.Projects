using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has two private integer fields (max and min). 
    /// The value of the max field cannot be less than the value of the min field. 
    /// Values ​​are assigned to fields using a public method. The method can be called 
    /// with one or two integer arguments. When the method is called, the arguments are 
    /// compared with the current values ​​of the fields. The largest value is assigned 
    /// to the max field, and the smallest value is assigned to the min field. 
    /// Provide a constructor that works in the same way as a method for assigning 
    /// values ​​to fields. The class must also have a method that displays the values ​​
    /// of the object's fields in the console window.
    /// </summary>
    internal class Ch6Task6
    {
        static void Main(string[] args)
        {
            int numOne = InputChecker.EnterInteger("Enter first number: ");
            int numTwo = InputChecker.EnterInteger("Enter second number: ");

            MyClass obj1 = new MyClass(numOne, numTwo);

            Console.WriteLine("Object one info: ");
            obj1.PrintInfo();

            int numThree = InputChecker.EnterInteger("Enter another number: ");
            MyClass obj2 = new MyClass(numThree);

            Console.WriteLine("Object two info: ");
            obj2.PrintInfo();
        }

        class MyClass
        {
            private int max = 0;
            private int min = 0;

            public MyClass(int numOne, int numTwo)
            {
                Set(numOne, numTwo);
            }

            public MyClass(int numOne)
            {
                Set(numOne);
            }

            public MyClass()
            {
                this.max = 0;
                this.min = 0;
            }

            public void Set (int numOne, int numTwo)
            {
                if (numOne > numTwo)
                {
                    if (numOne > this.max)
                    {
                        this.max = numOne;
                    }
                    if (numTwo < min)
                    {
                        this.min = numTwo;
                    }
                }
                else if (numOne < numTwo)
                {
                    if (numOne < this.min)
                    {
                        this.min = numOne;
                    }
                    if (numTwo > this.max)
                    {
                        this.max = numTwo;
                    }
                }
                else
                {
                    if (numOne > this.max)
                    {
                        this.max = numOne;
                    }
                    else if (numOne < this.min)
                    {
                        this.min = numOne;
                    }
                }
            }

            public void Set(int numOne)
            {
                if(numOne > this.max)
                {
                    this.max = numOne;
                }
                else if (numOne < this.min)
                {
                    this.min = numOne;
                }
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Max = {this.max}\nMin = {this.min}");
            }
        }
    }
}
