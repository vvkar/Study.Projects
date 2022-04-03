using System;

namespace Ch2Tasks
{
    /// <summary>
    /// Write a program that uses delegates and anonymous 
    /// methods (lambda expressions) to create an instance 
    /// of a delegate that is called without arguments and 
    /// returns a text value with the name of the day of 
    /// the week ("Monday", "Tuesday" and so on until "Sunday"). 
    /// Each time the instance is called again, the name of the 
    /// next day of the week is returned as a result. 
    /// After "Sunday" the result returns "Monday" and so on.
    /// </summary>
    internal class Ch2Task6
    {
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Sunday;

            WeekdayHandler weekDayShow = () =>
            {
                if ((int)dayOfWeek == 6)
                {
                    dayOfWeek = DayOfWeek.Sunday;
                }
                else dayOfWeek++;
                return dayOfWeek.ToString();
            };

            do
            {
                Console.WriteLine(weekDayShow());
                Console.ReadKey();
            }
            while (true);
        }

        delegate string WeekdayHandler();
    }
}
