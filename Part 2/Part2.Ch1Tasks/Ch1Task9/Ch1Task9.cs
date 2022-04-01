using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program that creates a class from an abstract 
    /// base class and an interface. The abstract class has 
    /// a field that is a reference to a protected character array. 
    /// The class constructor is passed a text argument, on the basis 
    /// of which a character array is created and filled. In an abstract 
    /// class, describe a method that, given an integer argument, 
    /// returns the value of the character at the corresponding 
    /// index in the array. Also in the abstract class, an abstract 
    /// method with two arguments (an integer and a character) 
    /// must be declared that does not return a result. 
    /// An interface must declare a method with the same name 
    /// but with one text argument. Also, an indexer (with two accessors) 
    /// with a character result and an integer index must be declared 
    /// in the interface. Based on the abstract class and interface, 
    /// you need to create a class. An abstract method from the base 
    /// class must be overridden so that it assigns a value to 
    /// an array element, a method from the interface must create 
    /// a new array, and the indexer must provide access 
    /// to the elements of the array.
    /// </summary>
    internal class Ch1Task9
    {
        static void Main(string[] args)
        {
            InputChecker checker = new InputChecker();
            string input = checker.EnterString();

            TaskClass taskObj = new TaskClass(input);

            int index = checker.EnterNonNegativeInteger();
            Console.WriteLine($"taskObj[{index}] = {taskObj[index]}");
            
            char symbol = checker.EnterChar();
            Console.WriteLine($"{taskObj[index]} => {symbol}");
            taskObj[index] = symbol;
            Console.WriteLine($"taskObj[{index}] = {taskObj[index]}");
            Console.WriteLine(taskObj.ToString());

            index = checker.EnterNonNegativeInteger("Enter another index: ");
            symbol = checker.EnterChar("Enter another symbol: ");
            taskObj.CommonMethod(index, symbol);
            Console.WriteLine(taskObj.ToString());

            string text = checker.EnterString();
            taskObj.CommonMethod(text);
            Console.WriteLine(taskObj.ToString());
        }

        class TaskClass : BaseClass, IArrayBuilder
        {
            public TaskClass(string text) : base(text) { }

            public char this[int index] 
            { 
                get => symbs[index]; 
                set => symbs[index] = value; 
            }

            public override void CommonMethod(int index, char symbol)
            {
                symbs[index] = symbol;
            }

            public void CommonMethod(string text)
            {
                symbs = text.ToCharArray();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (char symbol in symbs)
                {
                    sb.Append(symbol);
                }
                return "Object field is: " + sb.ToString();
            }
        }

        abstract class BaseClass
        {
            protected char[] symbs;

            public BaseClass(string text)
            {
                symbs = text.ToCharArray();
            }

            public char GetCharByIndex(int index)
            {
                return symbs[index];
            }

            public abstract void CommonMethod(int number, char symbol);
        }

        interface IArrayBuilder
        {
            void CommonMethod(string text);

            char this[int index] { get; set; }
        }
    }
}
