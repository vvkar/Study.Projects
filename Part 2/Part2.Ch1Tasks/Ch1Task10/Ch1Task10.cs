using System;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program that contains an abstract class and 
    /// two interfaces. The class must contain the declaration 
    /// of an abstract property (with two accessors), an abstract 
    /// indexer (with two accessors), and an abstract method. 
    /// The same property, indexer, and method must be in interfaces. 
    /// Based on the abstract class and interfaces, you need to create 
    /// a class. In this class, you must make an explicit implementation 
    /// for the property, indexer, and method for each of the interfaces. 
    /// Test the operation of the property, indexer, and method by 
    /// accessing the class object through an object variable 
    /// and through interface variables.
    /// </summary>
    internal class Ch1Task10
    {
        static void Main(string[] args)
        {
            TaskClass taskObj = new TaskClass("test");
            IFirst firstInterfaceVariable = taskObj;
            ISecond secondInterfaceVariable = taskObj;
            Console.WriteLine("----------------------------------------");
            string buffer = taskObj.Message;
            buffer = firstInterfaceVariable.Message;
            buffer = secondInterfaceVariable.Message;
            Console.WriteLine("----------------------------------------");
            char symb = taskObj[0];
            symb = firstInterfaceVariable[0];
            symb = secondInterfaceVariable[0];
            Console.WriteLine("----------------------------------------");
            taskObj[0] = 'A';
            firstInterfaceVariable[0] = 'B';
            secondInterfaceVariable[0] = 'C';
            Console.WriteLine("----------------------------------------");
            taskObj.PrintInfo();
            firstInterfaceVariable.PrintInfo();
            secondInterfaceVariable.PrintInfo();
        }

        class TaskClass : BaseClass, IFirst, ISecond
        {
            public TaskClass (string text) : base(text) { }

            public override char this[int index] 
            {
                get
                {
                    Console.WriteLine("TaskClass object indexer result!");
                    return 'T';
                }
                set
                {
                    Console.WriteLine("TaskClass object indexer set!");
                }
            }

            public override string Message 
            {
                get 
                {
                    Console.WriteLine("Task Object property get!");
                    return "TaskClass";
                }
                set
                {
                    Console.WriteLine("Task Object property set!");
                } 
            }

            public override void PrintInfo()
            {
                Console.WriteLine("Task Class object!");
            }

            char IFirst.this[int index]
            {
                get
                {
                    Console.WriteLine("IFirst variable indexer result!");
                    return 'F';
                }
                set
                {
                    Console.WriteLine("IFirst variable indexer set!");
                }
            }
            char ISecond.this[int index]
            {
                get 
                {
                    Console.WriteLine("ISecond variable indexer result!");
                    return 'S';
                }
                set
                {
                    Console.WriteLine("ISecond variable indexer set!");

                }
            }

            void IFirst.PrintInfo()
            {
                Console.WriteLine("IFirst variable!");
            }
            void ISecond.PrintInfo()
            {
                Console.WriteLine("ISecond variable!");
            }

            string IFirst.Message
            {
                get
                {
                    Console.WriteLine("IFirst property get!");
                    return "IFirst";
                }
                set
                {
                    Console.WriteLine("IFirst property set!");
                }
            }
            string ISecond.Message
            {
                get
                {
                    Console.WriteLine("ISecond property get!");
                    return "ISecond";
                }
                set 
                {
                    Console.WriteLine("ISecond property set!");
                }
            }
        }

        abstract class BaseClass
        {
            public abstract string Message { get; set; }
            public BaseClass(string text)
            {
                Message = text;
            }
            public abstract char this [int index] { get; set; }
            public abstract void PrintInfo();
        }

        interface IFirst
        {
            string Message { get; set; }
            char this[int index] { get; set; }
            void PrintInfo();
        }

        interface ISecond
        {
            string Message { get; set; }
            char this[int index] { get; set; }
            void PrintInfo();
        }
    }
}
