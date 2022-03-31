using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tasks
{
    /// <summary>
    /// Write a program that has a class with a character field 
    /// and the following overloaded operators: increment ++ 
    /// and decrement --, binary plus operator, and binary minus operator.
    ///Overload rules:
    ///applying an increment to an object causes the field with the value 
    ///to get the next character in the code table. Applying a decrement causes 
    ///the field to be set to the previous character in the code table.
    ///The value of an expression based on the increment/decrement operator is a 
    ///reference to the operand object. The binary plus operator can be used 
    ///to calculate the sum of an object and an integer, as well as the sum of an integer and an object. 
    ///In both cases a new object is returned as a result, the value of the character field 
    ///of which is determined by adding an integer to the character code from the operand object. 
    ///The minus binary operator can be used to calculate the difference between two objects.
    ///The result is an integer - the difference of character codes from operand objects.
    /// </summary>
    internal class Ch8Task1
    {
        static void Main(string[] args)
        {
            char symbol = InputChecker.EnterChar();

            TestClass testObject = new TestClass(symbol);

            Console.WriteLine("Created object character field: " + testObject);
            
            Console.WriteLine("Incremented object: " + ++testObject);

            int number = InputChecker.EnterInteger();

            testObject += number;

            Console.WriteLine($"Object + {number} = {testObject}");

            Console.WriteLine("Decremented object: " + --testObject);
        }

        class TestClass
        {
            private char symbol;

            public TestClass(char symbol)
            {
                this.symbol = symbol;
            }

            public static TestClass operator++ (TestClass obj)
            {
                obj.symbol++;
                return obj;
            }

            public static TestClass operator-- (TestClass obj)
            {
                obj.symbol--;
                return obj;
            }

            public static TestClass operator+ (TestClass obj, int number)
            {
                int newCharIndex = obj.symbol + number;
                return new TestClass((char)newCharIndex);
            }

            public static TestClass operator +(int number, TestClass obj)
            {
                return obj + number;
            }

            public override string ToString()
            {
                return this.symbol.ToString();
            }
        }
    }
}
