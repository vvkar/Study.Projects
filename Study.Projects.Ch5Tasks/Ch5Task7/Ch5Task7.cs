using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes 
    /// a one-dimensional character array as an argument. 
    /// In the process of calling a method, the elements of 
    /// the array are swapped in pairs: the first - with 
    /// the last, the second - with the penultimate one, and so on.
    /// </summary>
    internal class Ch5Task7
    {
        static void Main(string[] args)
        {
            int size = InputChecker.EnterPositive("Enter array size: ");

            char[] chars = ArrayBuilder.GenerateCharArray(size);

            Console.WriteLine("Generated array: ");

            ArrayBuilder.WriteArray(chars);

            char[] swappedArray = ArraySwapByPairs(chars);

            Console.WriteLine("Swapped array: ");

            ArrayBuilder.WriteArray(swappedArray);
        }

        static char[] ArraySwapByPairs(char [] array)
        {
            char[] resultArray = new char[array.Length];

            for (int i = 0; i <= array.Length/2; i++)
            {
                resultArray[i] = array[array.Length - (i + 1)];
                resultArray[resultArray.Length - (i + 1)] = array[i];
            }
            return resultArray;
        }
    }
}
