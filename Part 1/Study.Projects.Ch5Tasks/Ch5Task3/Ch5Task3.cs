using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes an array of integers 
    /// and an integer as an argument. As a result, the method returns a reference 
    /// to a new array, which is obtained from the several initial elements 
    /// of the original array (passed as the first argument to the method). 
    /// The number of elements to be taken from the original array is 
    /// determined by the second argument of the method. If the second argument 
    /// of the method is greater than the length of the array, passed as the first argument, 
    /// the method creates a copy of the original array and returns a reference to that copy.
    /// </summary>
    internal class Ch5Task3
    {
        static void Main(string[] args)
        {
            int size = InputChecker.EnterPositive("Enter an array size: ");

            int num = InputChecker.EnterPositive();

            int[] nums = ArrayBuilder.GenerateIntArray(size);

            Console.WriteLine("Generated array: ");

            ArrayBuilder.WriteArray(nums);

            int [] newArray = ArrayRebuild(nums, num);

            Console.WriteLine("Rebuild array: ");

            ArrayBuilder.WriteArray(newArray);
        }

        static int [] ArrayRebuild (int [] array, int num)
        {
            int[] resArray;

            if(array.Length >= num)
            {
                resArray = new int[num];

                for(int i = 0; i < num; i++)
                {
                    resArray[i] = array[i];
                }
            }
            else
            {
                resArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    resArray[i] = array[i];
                }
            }

            return resArray;
        }
    }
}
