using ClassLibrary;
using System.Threading;

class Ch6Task1
{
    static void Main()
    {
        InputChecker inputChecker = new InputChecker();
        int number = inputChecker.EnterNonNegativeInteger();
        int threadSleep = 500;

        Thread threadOne = new(() =>
        {
            Console.WriteLine("Start factorial calculating!");
            Thread.Sleep(threadSleep);
            Console.WriteLine($"{number}! = {GetFact(number)}");
        });

        Thread threadTwo = new(() =>
        {
            Console.WriteLine("Start double factorial calculating!");
            Thread.Sleep(threadSleep);
            Console.WriteLine($"{number}!! = {GetDoubleFact(number)}");
        });

        Thread threadThree = new(() =>
        {
            Console.WriteLine("Start Fibonacci calculating!");
            Thread.Sleep(threadSleep);
            Console.WriteLine($"Fibonacci #{number} = {GetFibonacci(number)}");
        });

        threadOne.Start();
        threadTwo.Start();
        threadThree.Start();

    }

    static int GetFact (int number)
    {
        int result = 1;
        for(int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static int GetDoubleFact(int number)
    {
        int result = 1;
        for(int i = number; i > 0; i -= 2)
        {
            result *= i;
        }
        return result;
    }

    static int GetFibonacci(int number)
    {
        int first = 0, second = 1;
        for (int i = 2; i < number; i++)
        {
            second += first;
            first = second - first;
        }
        return second;
    }
}