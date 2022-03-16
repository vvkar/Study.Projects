using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    /// <summary>
    /// Write a program with a static method that takes 
    /// an array of characters as an argument and returns 
    /// a reference to an array of integers consisting 
    /// of the character codes from the argument array.
    /// </summary>
    internal class Ch5Task4
    {
        static void Main(string[] args)
        {
            int size = InputChecker.EnterPositive("Enter a size of an array: ");

            char [] chars = ArrayBuilder.GenerateCharArray(size);

            Console.WriteLine("Generated char array: ");

            ArrayBuilder.WriteArray(chars);

            int[] nums = CharToIntArrayRebuild(chars);

            Console.WriteLine("Codes of char array elements: ");

            ArrayBuilder.WriteArray(nums);
        }

        static int[] CharToIntArrayRebuild(char [] chars)
        {
            int [] nums = new int[chars.Length];

            for(int i = 0; i < chars.Length; i++)
            {
                nums[i] = chars[i];
            }
            return nums;
        }
    }
}
