using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    public class ArrayBuilder
    {
        public static int[] GenerateIntArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }

        public static char[] GenerateCharArray(int size)
        {
            Random random = new Random();
            char[] array = new char[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = (char)random.Next((int)'A', (int)'z'+1);
            }
            return array;
        }

        public static void WriteArray <T> (T [] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
