using System;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that declares a delegate corresponding to 
    /// methods with an integer argument and an integer result. 
    /// It is necessary to describe a static method with two arguments, 
    /// each of which is a reference to an instance of the delegate 
    /// (method reference). The result of a static method is also 
    /// a reference to an instance of the delegate. A static method 
    /// works according to the following scheme: when called, references 
    /// to two methods (argument methods) are passed to it, and as a result, 
    /// the static method returns a reference to the method (result method). 
    /// The action of a method-result on its argument is equivalent to the 
    /// sequential application of methods-arguments to this argument. 
    /// In other words, if references f and h to some methods are passed 
    /// as arguments to a static method, then the result is a reference 
    /// to a method that, for argument n, evaluates the value f(h(n)). 
    /// Suggest a mechanism for checking the functionality of a static method.
    /// </summary>
    internal class Ch2Task8
    {
        static void Main(string[] args)
        {
            CalcMethod squaresPlusOne = n => n * (n + 1);
            CalcMethod cubes = n => n * n * n;
            CalcMethod newMethod = Combiner(squaresPlusOne, cubes);

            InputChecker checker = new InputChecker();
            int number = checker.EnterInteger();

            Console.WriteLine($"Your result is {newMethod(number)}");
        }

        static CalcMethod Combiner (CalcMethod firstMethod, CalcMethod secondMethod)
        {
            return number => firstMethod(secondMethod(number));
        }

        delegate int CalcMethod(int x);
    }
}
