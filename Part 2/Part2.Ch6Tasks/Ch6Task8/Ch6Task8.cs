using ClassLibrary;

/// <summary>
/// Write a program that creates a two-dimensional 
/// character array. The array is filled with random 
/// characters. Filling is done in columns. A separate 
/// child thread is launched to populate each column. 
/// </summary>
class Ch6Task8
{
    static void Main()
    {
        InputChecker inputChecker = new();
        int rows = inputChecker
            .EnterIntegerMoreThenZero("Enter number of rows: ");
        int cols = inputChecker
            .EnterIntegerMoreThenZero("Enter number of columns: ");
        int threadSleepTime = 250;

        char[,] array = new char[rows, cols];

        Thread[] threads = new Thread[array.GetLength(1)];

        for (int j = 0; j < threads.Length; j++)
        {
            int p = j;
            Random rnd = new();
            threads[p] = new(() =>
            {
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    array[i, p] = (char)rnd.Next('A', 'z' + 1);
                    Thread.Sleep(threadSleepTime);
                }
            });
            threads[p].Start();
        }

        if(threads[threads.Length - 1].IsAlive)
            threads[threads.Length - 1].Join();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"|{array[i, j]}|");
            }
            Console.WriteLine();
        }
    }
}