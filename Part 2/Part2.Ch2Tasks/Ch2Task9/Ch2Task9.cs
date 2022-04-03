using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program containing a static method 
    /// with three real (double) arguments. The result 
    /// of a static method is a reference to a method 
    /// that calculates a quadratic trinomial with coefficients 
    /// determined by the arguments of the static method. 
    /// In other words, if a static method is called with 
    /// numeric arguments a, b, and c, then the result is 
    /// a reference to a method that, given a double argument x, 
    /// returns the value of the expression a*x*x+b*x+c as a result.
    /// </summary>
    internal class Ch2Task9
    {
        static void Main(string[] args)
        {
            InputChecker inputChecker = new InputChecker();

            int a = inputChecker.EnterInteger("Enter 'a' = ");
            int b = inputChecker.EnterInteger("Enter 'b' = ");
            int c = inputChecker.EnterInteger("Enter 'c' = ");
            int x = inputChecker.EnterInteger("Enter 'x' = ");

            GeometricalFunction func = GetNewMethod(a, b, c);

            Console.WriteLine($"{a}*({x}^2) + {b}*{x} + c = {func(x)}");
        }

        delegate double GeometricalFunction(double x);

        static GeometricalFunction GetNewMethod (double a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }
    }
}
