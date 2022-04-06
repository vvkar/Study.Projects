/// <summary>
using ClassLibrary;

/// Write a program that creates a one-dimensional integer 
/// array and starts two child threads. One child thread 
/// searches for the element with the largest value, and 
/// the second thread searches for the element with the 
/// smallest value. The found values are displayed 
/// in the console window.
/// </summary>
class Ch6Task6
{
    static void Main()
    {
        InputChecker inputChecker = new();
        int arraySize = inputChecker.
            EnterIntegerMoreThenZero("Enter array size: ");

        int [] array = new int[arraySize];
        FillArray(array);
        PrintArray(array);

        Thread findingMax = new(()=>
        {
            Console.WriteLine($"Array max element is " +
                FindMax(array));
        });
        Thread findingMin = new(() =>
        {
            Console.WriteLine($"Array min element is " +
                FindMin(array));
        });
        findingMax.Start();
        findingMin.Start();
    }

    static void FillArray(int[] array)
    {
        Random random = new();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }
    }
    static void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"|{array[i]}|");
        }
        Console.WriteLine();
    }
    static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i] > max) 
                max = array[i];
            Thread.Sleep(100);
        }
        return max;
    }

    static int FindMin(int[] array)
    {
        int min = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] < min)
                min = array[i];
            Thread.Sleep(100);
        }
        return min;
    }
}