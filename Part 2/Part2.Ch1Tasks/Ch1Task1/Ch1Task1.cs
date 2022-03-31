using System;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program that contains an abstract base class 
    /// with a protected field that is a reference to an integer array. 
    /// The class must have a constructor with one argument (defines 
    /// the size of the array and creates it), an integer property 
    /// (the value is the size of the array), an abstract method 
    /// (no arguments, does not return a result), and an indexer 
    /// with an integer index (readable and writable). In the derived 
    /// class, you need to describe the abstract method from the 
    /// bass class so that it displays the contents of the array 
    /// in the console. Define an indexer so that it can be used 
    /// to read the value of an array element and assign a value 
    /// to the array element.
    /// </summary>
    internal class Ch1Task1
    {
        static void Main(string[] args)
        {
            InputChecker inputer = new InputChecker();
            int arraySize = inputer.EnterIntegerMoreThenZero();
            TaskClass testArrayObj = new TaskClass(arraySize);
            
            testArrayObj.FillArrayWithRandoms();
            testArrayObj.PrintArray();

            int indexToChange = inputer.EnterNotNegativeInteger("Enter index of element to change: ");
            int numberToChange = inputer.EnterInteger("Enter number to change: ");
            testArrayObj[indexToChange] = numberToChange;

            testArrayObj.PrintArray();

            int indexToPrint = inputer.EnterNotNegativeInteger("Enter an index of number to be printed: ");
            Console.WriteLine("Your number: " + testArrayObj[indexToPrint]);
        }

        abstract class BaseClass
        {
            protected int[] intArray;
            public int ArraySize
            {
                get { return intArray.Length; }
            }

            public BaseClass(int arraySize)
            {
                intArray = new int[arraySize];
            }

            public abstract void PrintArray();

            public abstract int this [int index] { get; set; }
        }

        class TaskClass : BaseClass
        {
            public TaskClass(int arraySize) : base(arraySize)
            {
            }

            public override int this[int index] 
            {
                get
                {
                    if(index < 0 || index >= intArray.Length)
                    {
                        throw new ArgumentOutOfRangeException("index");
                    }

                    return intArray[index];
                }
                set
                {
                    if (index < 0 || index >= intArray.Length)
                    {
                        throw new ArgumentOutOfRangeException("index");
                    }

                    intArray[index] = value;
                }
            }

            public override void PrintArray()
            {
                for(int i = 0; i < intArray.Length; i++)
                {
                    Console.Write($"|{intArray[i]}|");
                }
                Console.WriteLine();
            }

            public void FillArrayWithRandoms()
            {
                Random rand = new Random();

                for(int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = rand.Next(1, 100);
                }
            }
        }
    }
}
