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

        public static int[,] Generate2DimIntArray(int rows, int cols)
        {
            Random random = new Random();
            int[,] array = new int[rows, cols];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
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

        public static void WriteArray<T>(T[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[] FromToIntArrayGenerate (int from, int to)
        {
            int size = Math.Abs(from - to) + 1;

            int [] array = new int[size];

            if(from < to)
            {
                for (int i = 0; i < size && from <= to; i++, from++)
                {
                    array[i] = from;
                }
            }
            else
            {
                for (int i = 0; i < size && from >= to; i++, from--)
                {
                    array[i] = from;
                }
            }
            
            return array;
        }

        public static char[] FromToCharArrayGenerate(char from, char to)
        {
            int size = Math.Abs(from - to) + 1;

            char[] array = new char[size];

            if (from < to)
            {
                for (int i = 0; i < size && from <= to; i++, from++)
                {
                    array[i] = from;
                }
            }
            else
            {
                for (int i = 0; i < size && from >= to; i++, from--)
                {
                    array[i] = from;
                }
            }

            return array;
        }
    }
}
