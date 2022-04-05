using ClassLibrary;

/// <summary>
/// Write a program in which two threads fill 
/// an integer array. One thread fills the array 
/// from beginning to end with numbers that are 
/// powers of two (2^0, 2^1, 2^2, and so on). Another 
/// thread fills the array from end to beginning with 
/// numbers that are powers of a triple (3^0, 3^1, 
/// 3^2, and so on).
/// </summary>
class Ch6Task4
{
    static void Main()
    {
        InputChecker inputChecker = new InputChecker();
        int arraySize = inputChecker.EnterIntegerMoreThenZero("Enter array size: ");
        int[] array = new int[arraySize];
        
        int beginingIndex = 0, endingIndex = arraySize - 1;
        int threadSleepTime = 250;

        Thread powersTwo = new(() =>
        {
            for ( ; beginingIndex < endingIndex; beginingIndex++)
            {
                array[beginingIndex] = (int)Math.Pow(2, beginingIndex);
                Thread.Sleep(threadSleepTime);
            }
        });
        Thread powersThree = new(() =>
        {
            for(int power = 0; beginingIndex < endingIndex; endingIndex--, power++)
            {
                array[endingIndex] = (int)Math.Pow(3, power);
                Thread.Sleep(threadSleepTime);
            }
        });

        powersTwo.Start();
        powersThree.Start();

        if(powersTwo.IsAlive)
            powersTwo.Join();

        if(powersThree.IsAlive)
            powersThree.Join();

        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"|{array[i]}|");
        }
    }
}