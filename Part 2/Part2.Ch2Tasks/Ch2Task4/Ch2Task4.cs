using System;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that declares a delegate to handle methods 
    /// that have an integer argument and an integer result. Describe 
    /// a class with an indexer (only available for reading a value). 
    /// The result indexer must return a reference to the delegate instance. 
    /// The delegate instance refers to a method that has an integer argument. 
    /// As a result, the method returns an integer value obtained by raising 
    /// the method argument to the power determined by the object index. 
    /// The general effect is this: if some object obj of the class is indexed 
    /// with a non-negative index k and the argument n is specified in parentheses 
    /// (a command like obj[k](n)), then the result of such an expression 
    /// should be the value n to the power of k.
    /// </summary>
    internal class Ch2Task4
    {
        static void Main(string[] args)
        {
            InputChecker inputChecker = new InputChecker();
            TaskClass taskObj = new TaskClass();
            while (true)
            {
                int number = inputChecker.EnterInteger("Enter any number to exponentiate: ");
                int power = inputChecker.EnterInteger("Enter power: ");
                Console.WriteLine($"obj[{power}]({number}) = {taskObj[power](number)}");
            }
        }

        delegate int MyDelegate(int number);

        class TaskClass
        {
            public MyDelegate this[int index]
            {
                get
                {
                    return (n) => (int)Math.Pow(n, index);
                }
            }
        }
    }
}
