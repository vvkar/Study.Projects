using System;

namespace Ch1Tasks
{
    internal class Ch1Task6
    {
        static void Main(string[] args)
        {
            TaskClass indexerObj = new TaskClass();
            InputChecker checker = new InputChecker();

            int number = checker.EnterNonNegativeInteger();
            Console.WriteLine($"indexerObj[{number}] = {indexerObj[number]}");

            char symbol = checker.EnterChar();
            Console.WriteLine($"indexerObj[{symbol}] = {indexerObj[symbol]}");
        }

        class TaskClass : IIndexerByChar, IIndexerByInt
        {
            public int this[char symbol] => symbol;

            public char this[int number] => (char)number;
        }

        interface IIndexerByChar
        {
            int this[char symbol] { get; }
        }

        interface IIndexerByInt
        {
            char this[int number] { get; }
        }
    }
}
