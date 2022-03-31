using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program that describes an interface with a method 
    /// with no arguments that returns an integer as a result. 
    /// Create two classes based on the interface. Each class must have an integer field. 
    /// In the first class the method returns the sum of even numbers, in the second class the method returns the sum of odd numbers. The number of terms is determined by the field of the object from which the method is called. Test the method by accessing the class object through an object variable and through an interface variable.
    /// </summary>
    internal class Ch1Task3
    {
        static void Main(string[] args)
        {
            var checker = new InputChecker();
            int numOne = checker.EnterIntegerMoreThenZero("Enter number to create first object: ");
            int numTwo = checker.EnterIntegerMoreThenZero("Enter number to create second object: ");

            var evenObj = new EvenNumber(numOne);
            var oddObj = new OddNumber(numTwo);

            Console.WriteLine($"The sum of {numOne} even numbers = {evenObj.GetSum()}");
            Console.WriteLine($"The sum of {numTwo} odd numbers = {oddObj.GetSum()}");

            ISummable interfaceVal = evenObj;
            Console.WriteLine($"First result invoked in interface variable: {interfaceVal.GetSum()}");
            interfaceVal = oddObj;
            Console.WriteLine($"Second result invoked in interface variavle: {interfaceVal.GetSum()}");
        }

        interface ISummable
        {
            int GetSum();
        }

        class EvenNumber : ISummable
        {
            private int _numOfIterations;

            public EvenNumber(int number)
            {
                _numOfIterations = number;
            }

            public int GetSum()
            {
                int sum = 0;
                for(int i = 0; i <= _numOfIterations; i++)
                {
                    sum += 2 * _numOfIterations;
                }
                return sum;
            }
        }

        class OddNumber : ISummable
        {
            private int _numOfIterations;

            public OddNumber(int number)
            {
                _numOfIterations= number;
            }

            public int GetSum()
            {
                int sum = 0;
                for (int i = 0; i <= _numOfIterations; i++)
                {
                    sum += 2*_numOfIterations + 1;
                }
                return sum;
            }
        }
    }
}
