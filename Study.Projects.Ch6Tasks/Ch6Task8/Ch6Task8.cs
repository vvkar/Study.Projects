using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has a private static integer field 
    /// with zero initial value. The class must describe a static method that, 
    /// displays the current value of the static field, after that the 
    /// value of the field is incremented by one.
    /// </summary>
    internal class Ch6Task8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to increase or esc to exit");
            while (true)
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    Counter.Count();
                }
                else if(input.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.CursorLeft = 0;
                }
            }
        }

        class Counter
        {
            private static int count = 0;

            public static void Count()
            {
                Console.WriteLine(count++);
            }
        }
    }
}
