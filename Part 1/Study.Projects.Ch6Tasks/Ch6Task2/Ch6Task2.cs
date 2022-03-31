using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    /// <summary>
    /// Write a program with a class that has two character fields and a method. 
    /// It does not return a result and it has no arguments. When called, 
    /// the method prints to the console window all the characters from 
    /// the code table that are between the characters that are the values 
    /// of the fields of the object (from which the method is called).
    /// </summary>
    internal class Ch6Task2
    {
        static void Main(string[] args)
        {
            char firstSymb = InputChecker.InputChar("Enter first symbol: ");
            char secondSymb = InputChecker.InputChar("Enter second symbol: ");

            MyClass obj = new MyClass(firstSymb, secondSymb);

            obj.PrintAll();
        }

        class MyClass
        {

            public char firstSymb;
            public char secondSymb;

            public MyClass(char firstSymb, char secondSymb)
            {
                this.firstSymb = firstSymb;
                this.secondSymb = secondSymb;
            }

            public void PrintAll()
            {
                if(firstSymb != secondSymb)
                {
                    Console.WriteLine($"The symbols between {firstSymb} and {secondSymb}:");

                    if (firstSymb < secondSymb)
                    {
                        for (char c = firstSymb; c <= secondSymb; c++)
                        {
                            Console.Write(c + " ");
                        }
                    }
                    else
                    {
                        for (char c = firstSymb; c >= secondSymb; c--)
                        {
                            Console.Write(c + " ");
                        }
                    }
                }
                else
                {
                    Console.Write("Symbols are equal!");
                }
                Console.WriteLine();
            }
        }
    }
}
