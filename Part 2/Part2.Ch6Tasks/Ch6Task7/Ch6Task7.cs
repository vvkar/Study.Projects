using ClassLibrary;
/// <summary>
/// Write a program that creates a two-dimensional 
/// integer array. The array is filled line by line: 
/// the first line is filled with numbers that are powers 
/// of two (2^0, 2^1, 2^2, and so on), the second line is 
/// filled with powers of three (3^0, 3^1, 3^2, and so on), etc. 
/// A child thread is started to fill each row. Object variables 
/// for threads should be organized as an array.
/// </summary>
class Ch6Task7
{
    static void Main()
    {
        InputChecker inputChecker = new();
        int rows = inputChecker
            .EnterIntegerMoreThenZero("Enter number of rows: ");
        int columns = inputChecker
            .EnterIntegerMoreThenZero("Enter number of rows: ");

        int[,] array = new int[rows, columns];

        Thread [] threads = new Thread[array.GetLength(0)];

        for (int i = 0; i < rows; i++)
        {
            int p = i;
            threads[p] = new (() =>
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[p, j] = (int)Math.Pow(p + 2, j);
                    Thread.Sleep(100);
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
                Console.Write($"|{array[i, j],-5}|");
            }
            Console.WriteLine();
        }
    }
}