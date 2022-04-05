using ClassLibrary;

/// <summary>
/// Write a program in which an integer variable 
/// on the main thread receives a random value at 
/// regular intervals. Two child threads periodically 
/// (at regular intervals) check the value of the variable. 
/// The first thread checks if the value of the variable 
/// is odd, and the second thread checks if the value of 
/// the variable is divisible by 3. If the check is successful, 
/// the corresponding thread prints a message to the console window.
/// </summary>
class Ch6Task3
{
    static void Main()
    {
        InputChecker inputChecker = new InputChecker();
        int arraySize = inputChecker.EnterIntegerMoreThenZero();
        char[] array = new char[arraySize];
        int threadSleepTime = 250;

        Thread evenIndexThread = new(() =>
        {
            char symbol = 'A';
            for (int i = 0; i < arraySize; i += 2)
            {
                array[i] = symbol++;
                Thread.Sleep(threadSleepTime);
            }
        });
        Thread oddIndexThread = new(() =>
        {
            char symbol = 'я';
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = symbol--;
                Thread.Sleep(threadSleepTime);
            };
        });
        evenIndexThread.Start();
        oddIndexThread.Start();

        if(evenIndexThread.IsAlive)
            evenIndexThread.Join();

        if(oddIndexThread.IsAlive)
            oddIndexThread.Join();

        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"|{array[i]}|");
        }
    }
}