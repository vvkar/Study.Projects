using System;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program containing a static method. 
    /// The first argument to the static method is an 
    /// integer array. The second argument to the static 
    /// method is a reference to another method. 
    /// An argument method must have an integer argument 
    /// and must return an integer result. As a result, 
    /// the static method returns an integer array. 
    /// The elements of this array are calculated as the 
    /// result of calling the argument method, if the 
    /// values ​​of the elements from the argument array 
    /// are passed to it. Suggest a mechanism for checking 
    /// the functionality of this static method.
    /// </summary>
    internal class Ch2Task7
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] array = new int[size];

            InputDelegate squares = n => (int)Math.Pow(n, 2);
            InputDelegate cubes = n => (int)Math.Pow(n, 3);

            array = FillArray(array, squares);
            foreach(int i in array)
            {
                Console.Write($"{i, 5}");
            }
            Console.WriteLine();

            array = FillArray(array, cubes);
            foreach(int i in array)
            {
                Console.Write($"{i, 5}");
            }
            Console.WriteLine();
        }

        static int[] FillArray (int[] inputArray, InputDelegate method)
        {
            for(int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = method(i);
            }
            return inputArray;
        }

        delegate int InputDelegate (int inputNumber);
    }
}
