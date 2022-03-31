using System;

namespace Ch1Tasks
{
    /// <summary>
    /// Write a program where a class is created 
    /// based on two interfaces. Each interface has 
    /// a read-only text property with the same name. 
    /// In the class, perform a general (implicit) 
    /// implementation of the property, as well as an
    /// explicit specialization of the property for each 
    /// of the interfaces. Check the value of a property 
    /// for a class object by referencing the object 
    /// through the object variable and interface variables.
    /// </summary>
    internal class Ch1Task8
    {
        static void Main(string[] args)
        {
            TaskClass taskObj = new TaskClass();
            Console.WriteLine(taskObj.Info);

            IFirst firstInerfObj = taskObj;
            Console.WriteLine(firstInerfObj.Info);

            ISecond secondInerfObj = taskObj;
            Console.WriteLine(secondInerfObj.Info);
        }

        class TaskClass : IFirst, ISecond
        {
            public string Info => "Invoked in class object!";

            string IFirst.Info => "Invoked in IFirst interface variable!";

            string ISecond.Info => "Invoked in ISecond interface variable!";
        }

        interface IFirst
        {
            string Info { get; }
        }
        interface ISecond
        {
            string Info { get; }
        }
    }
}
