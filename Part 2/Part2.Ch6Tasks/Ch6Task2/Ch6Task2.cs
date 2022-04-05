/// <summary>
/// Write a program in which an integer variable on 
/// the main thread receives a random value at regular 
/// intervals. Two child threads periodically (at regular 
/// intervals) check the value of the variable. The first 
/// thread checks if the value of the variable is odd, and 
/// the second thread checks if the value of the variable 
/// is divisible by 3. If the check is successful, the 
/// corresponding thread prints a message to the console window.
/// </summary>
class Ch6Task2
{
    static void Main()
    {
        Random random = new Random();
        int number = random.Next(100);
        int threadSleepTime = 500;

        Thread threadOne = new(() =>
        {
            Console.WriteLine("Thread one started!");
            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even!");
                }
                Thread.Sleep(threadSleepTime);
            }
        });

        Thread threadTwo = new(() =>
        {
            Thread.Sleep(threadSleepTime/2);
            Console.WriteLine("Thread two started!");
            while (true)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divisable by 3!");
                }
                Thread.Sleep(threadSleepTime);
            }
        });

        threadOne.Start();
        threadTwo.Start();

        while (true)
        {
            number = random.Next(100);
            Thread.Sleep(threadSleepTime/2);
        }
    }
}