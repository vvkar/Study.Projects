using System;

namespace Ch1Tasks
{
    public class Ch1Task2
    {
        static void Main(string[] args)
        {
            InputChecker checker = new InputChecker();
            string input = checker.EnterString();
            TaskClass taskObj = new TaskClass(input);

            int indexOfChar = checker.EnterNonNegativeInteger();

            try
            {
                Console.WriteLine("Your char code is: " + taskObj[indexOfChar]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The length of your string: " + taskObj.Length);
            taskObj.PrintInfo();

            Console.Write("Enter new text: ");
            input = Console.ReadLine();
            taskObj.SetNewText(input);
            taskObj.PrintInfo();
        }
    }

    abstract class BaseClass
    {
        protected string text;
        public BaseClass(string input)
        {
            this.text = input;
        }
        public abstract int Length
        {
            get;
        }
        public abstract int this[int index]
        {
            get;
        }
        public abstract void SetNewText(string newText);
        public abstract void PrintInfo();
    }

    class TaskClass : BaseClass
    {
        public TaskClass(string text) : base(text) { }
        public override int this[int index]
        {
            get => (int)text[index];
        }
        public override int Length
        {
            get => text.Length;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Text field: " + this.text);
        }
        public override void SetNewText(string newText)
        {
            this.text = newText;
        }
    }
}
