using System;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that uses delegates and anonymous methods 
    /// (lambda expressions) to create an instance of a delegate 
    /// that is called without arguments and returns a number from 
    /// the Fibonacci sequence as a result - with each new call, 
    /// we get a new number in the sequence. In the Fibonacci sequence, 
    /// the first two numbers are equal to one, and each subsequent 
    /// number is equal to the sum of the previous two.
    /// </summary>
    internal class Ch2Task5
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1;
            Fibonacci getFib = () =>
            {
                second += first;
                first = second - first;
                return second;
            };
            int count = 1;
            var key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine($"Fibonacci #{count} = {getFib()}");
                Console.WriteLine("Press Enter to get next Fibonacci number!");
                key = Console.ReadKey();
            }
            while (key.Key == ConsoleKey.Enter);
        }

        delegate int Fibonacci();
    }
}
