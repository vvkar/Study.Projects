using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has a private integer field. 
    /// A value is assigned to a field using a public method. An integer 
    /// can be passed as an argument to the method, and the method can 
    /// also be called without arguments. If the method is called without arguments, 
    /// then the field gets a zero value. If the method is called with an integer 
    /// argument, then that value is assigned to the field. However, if the value 
    /// passed as an argument to the method is greater than 100, then the field's value 
    /// is set to 100. Provide a constructor in your class that works in the same way 
    /// as the method. Also, the class must have a method that allows you 
    /// to check the value of the field.
    /// </summary>
    internal class Ch6Task5
    {
        static void Main(string[] args)
        {
            int number = InputChecker.EnterInteger();

            MyClass obj1 = new MyClass(number);

            MyClass obj2 = new MyClass();

            Console.Write("Object one number: ");
            obj1.PrintNumber();
            Console.Write("Object two number: ");
            obj2.PrintNumber();
        }

        class MyClass
        {
            private int number;

            public MyClass(int number)
            {
                this.Set(number);
            }
            public MyClass() : this(0)
            {

            }

            public void Set(int number)
            {
                this.number = number > 100 ? 100 : number;
            }

            public void Set()
            {
                this.Set(0);
            }

            public void PrintNumber()
            {
                Console.WriteLine(this.number);
            }
        }
    }
}
