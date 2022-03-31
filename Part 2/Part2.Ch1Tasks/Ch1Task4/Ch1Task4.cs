using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1Tasks
{
    internal class Ch1Task4
    {
        static void Main(string[] args)
        {
            var checker = new InputChecker();
            int numOne = checker.EnterInteger("Enter first number: ");
            int numTwo = checker.EnterInteger("Enter second number: ");
            TaskClass taskObj = new TaskClass(numOne, numTwo);

            int index = checker.EnterInteger("Enter index to check object indexer: ");
            Console.WriteLine($"{index}%2 = {index%2} => taskObj[{index}] = {taskObj[index]}");

            int number = checker.EnterInteger("Enter number to perform calculation: ");
            Console.WriteLine("Calculation result = " + taskObj.Calculate(number));
        }

        class TaskClass : BaseClass, ICalculator
        {
            public TaskClass(int numOne, int numTwo) 
                : base(numOne, numTwo) { }

            public override int this[int index] 
            { 
                get
                {
                    if (index % 2 == 0) return numOne;
                    return numTwo;
                } 
            }

            public int Calculate (int number) 
                => (numOne + numTwo) * number;
        }

        abstract class BaseClass
        {
            protected int numOne;
            protected int numTwo;

            public BaseClass(int numOne, int numTwo)
            {
                this.numOne = numOne;
                this.numTwo = numTwo;
            }

            public abstract int this [int index]
            {
                get;
            }
        }

        interface ICalculator
        {
            int Calculate(int number);
        }
    }
}
