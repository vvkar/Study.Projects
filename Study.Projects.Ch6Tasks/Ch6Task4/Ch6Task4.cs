using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has a character and an integer field. 
    /// In class must described versions of the constructor with two arguments, 
    /// as well as with one argument of the double type. In the latter case, 
    /// the real part of the argument determines the character code (the value 
    /// of the character field), and the fractional part (including tenths and hundredths) 
    /// determines the value of the integer field.
    /// </summary>
    internal class Ch6Task4
    {
        static void Main(string[] args)
        {
            char symb = InputChecker.InputChar();
            int number = InputChecker.EnterInteger();

            MyClass obj1 = new MyClass(symb, number);

            double realNum = InputChecker.EnterDouble();

            MyClass obj2 = new MyClass(realNum);

            Console.WriteLine("Object one info: ");
            obj1.Print();
            Console.WriteLine("Object two info: ");
            obj2.Print();
        }

        class MyClass
        {
            private char symb;
            private int num;

            public MyClass(char symb, int num)
            {
                this.symb = symb;
                this.num = num;
            }
            public MyClass(double input)
            {
                int charCode = (int)input;

                this.symb = (char)charCode;

                int checkNum = (int)(input % 1 * 100);

                if (checkNum % 10 == 0)
                {
                    this.num = checkNum / 10;
                }
                else
                {
                    this.num = checkNum;
                }
            }
            public void Print()
            {
                Console.WriteLine($"Symbol: {this.symb}, number: {this.num}");
            }
        }
    }
}
