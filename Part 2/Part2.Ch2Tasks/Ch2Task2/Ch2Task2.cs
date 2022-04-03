using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that declares a delegate for methods with 
    /// a symbolic argument that do not return a result. Describe 
    /// a class that should have a character field and a method that 
    /// allows you to assign a value to a character field of an object. 
    /// The method has one character argument and the method does not 
    /// return a result. Create an array of objects of the given class. 
    /// Create an instance of the delegate. In the call list of this delegate, 
    /// you need to add references to the method (assigning a value to the 
    /// character field) of each object from the array. Check the result 
    /// of calling such a delegate instance.
    /// </summary>
    internal class Ch2Task2
    {
        static void Main(string[] args)
        {
            InputChecker checker = new InputChecker();

            int arraySize = checker.EnterIntegerMoreThenZero("Enter object array size: ");

            TaskClass[] objArray = new TaskClass[arraySize];
            TaskDelegate setSymbForAll = null;

            for(int i = 0; i < objArray.Length; i++)
            {
                objArray[i] = new TaskClass();
                setSymbForAll += objArray[i].SetSymb;
            }
            char symb = checker.EnterChar();
            setSymbForAll?.Invoke(symb);

            for(int i = 0; i < objArray.Length; i++)
            {
                Console.WriteLine($"Object #{i} symbol field is: {objArray[i]}");
            }
        }

        delegate void TaskDelegate(char symbol);

        class TaskClass
        {
            private char _symbol;

            public void SetSymb(char symbol)
            {
                this._symbol = symbol;
            }

            public override string ToString()
            {
                return _symbol.ToString();
            }
        }
    }
}
