using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that has a class with an event. 
    /// The event is handled by methods that have a text 
    /// argument and do not return a result. The class must 
    /// have a text field in which, when creating an object 
    /// of the class, the name of the object is written. 
    /// The class must describe a method for generating an event, 
    /// which is called without arguments. When generating an event, 
    /// the value of the text field of the object that generates 
    /// the event is passed as an argument. Another class declared 
    /// in the program must contain a method with a text argument 
    /// that does not return a result. When called, the method 
    /// displays the value of its text argument. In the main 
    /// method of the program, it is necessary to create two 
    /// objects of the first class and one object of the second 
    /// class. For events of objects of the first class, the method 
    /// of the object of the second class is registered by the handler 
    /// (it turns out that the method of the same object is registered 
    /// by the handler for events of two objects). For each of the 
    /// objects of the first class, you need to generate an event. 
    /// In this case, the method registered by the handler must 
    /// display the name of the object that generated the event.
    /// </summary>
    internal class Ch2Task10
    {
        static void Main(string[] args)
        {
            TaskClassOne objOne = new TaskClassOne("First object!");
            TaskClassOne objTwo = new TaskClassOne("Second object!");

            TaskClassTwo anotherClassObj = new TaskClassTwo();

            objOne.MessageHandler += anotherClassObj.Print;
            objTwo.MessageHandler += anotherClassObj.Print;

            objOne.InvokeEvent();
            objTwo.InvokeEvent();
        }

        delegate void MessageMethods(string message);

        class TaskClassOne
        {
            public string name;
            public event MessageMethods MessageHandler;
            public TaskClassOne(string name)
            {
                this.name = name;
            }
            public void InvokeEvent()
            {
                MessageHandler?.Invoke(name);
            }
        }

        class TaskClassTwo
        {
            public void Print(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
