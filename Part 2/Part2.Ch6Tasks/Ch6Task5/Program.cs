using ClassLibrary;
/// <summary>
/// Write a program containing a class with two fields: 
/// one is a reference to an integer array, and the second 
/// field is a reference to a character array. Create an 
/// object of the class, and also run two child threads. 
/// One child thread must fill the object's character array, 
/// and the second child thread must fill the object's integer 
/// array. Suggest a filling method yourself (for example, 
/// random characters and numbers).
/// </summary>
class Ch6Task5
{
    static void Main()
    {
        InputChecker inputChecker = new();
        int arraysSize = inputChecker.
            EnterIntegerMoreThenZero("Enter arrays size: ");
        ArraysHolder arraysObj = new(arraysSize);
        int threadSleepTime = 250;

        Thread threadIntArrayFill = new(() =>
        {
            Random rndInt = new();
            for(int i = 0; i < arraysObj.IntArray.Length; i++)
            {
                arraysObj.IntArray[i] = rndInt.Next(100);
                Thread.Sleep(threadSleepTime);
            }
        });
        Thread threadCharArrayFill = new(() =>
        {
            Random rndChar = new();
            for(int i = 0; i < arraysObj.CharArray.Length; i++)
            {
                arraysObj.CharArray[i] = (char)rndChar.Next('A', 'Z' + 1);
                Thread.Sleep(threadSleepTime);
            }
        });

        threadIntArrayFill.Start();
        threadCharArrayFill.Start();

        if(threadIntArrayFill.IsAlive)
            threadIntArrayFill.Join();

        if (threadCharArrayFill.IsAlive)
            threadCharArrayFill.Join();

        for(int i = 0; i < arraysObj.IntArray.Length; i++)
        {
            Console.Write($"|{arraysObj.IntArray[i]}|");
        }

        Console.WriteLine();

        for (int i = 0; i < arraysObj.CharArray.Length; i++)
        {
            Console.Write($"|{arraysObj.CharArray[i]}|");
        }
    }

    class ArraysHolder
    {
        public int[]? IntArray { get; set; }
        public char[]? CharArray { get; set; }

        public ArraysHolder(int arraysSize)
        {
            IntArray = new int[arraysSize];
            CharArray = new char[arraysSize];
        }
    }
}