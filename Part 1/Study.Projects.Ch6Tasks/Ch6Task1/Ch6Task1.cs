using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    internal class Ch6Task1
    {
        /// <summary>
        /// Write a program with a class that has a private character field 
        /// and three public methods. One method allows you to assign a value 
        /// to a field. Another method, when called, returns a character code. 
        /// The third method allows you to display the symbol (field value) 
        /// and its code in the console window.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char symb = InputChecker.InputChar();

            MyClass obj = new MyClass();

            obj.Set(symb);

            int code = obj.GetCode();

            obj.Print();

            Console.WriteLine("Its code: " + code);
        }

        class MyClass
        {
            private char symb;

            public void Set(char symb)
            {
                this.symb = symb;
            }

            public int GetCode()
            {
                return this.symb;
            }

            public void Print()
            {
                Console.WriteLine("The symbol is: " + this.symb);
            }
        }
    }
}
