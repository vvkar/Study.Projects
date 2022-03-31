using System;

namespace Ch1Tasks
{
    internal class Ch1Task5
    {
        static void Main(string[] args)
        {
            TaskClass getter = new TaskClass();
            InputChecker checker = new InputChecker();

            int number = checker.EnterNonNegativeInteger();
            Console.WriteLine($"Char by your code {number} is {getter.GetCharByCode(number)}");

            char symbol = checker.EnterChar();
            Console.WriteLine($"Code of your symbol {symbol} is {getter.GetCharCode(symbol)}");
        }

        class TaskClass : ICharable, IIntable
        {
            public int GetCharCode(char symbol)
            {
                return symbol;
            }

            public char GetCharByCode(int code)
            {
                return (char)code;
            }
        }

        interface ICharable
        {
            int GetCharCode(char symbol);
        }

        interface IIntable
        {
            char GetCharByCode(int code);
        }
    }
}
