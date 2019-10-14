using System;

namespace CSHARP_WHAT_IS_NEW
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * OLD WAY
             * to return multiple values from a method was necessary to create an object or something similar
             */

            /*
             *  NEW WAY
             *  it's possible to return multiple values from a method, if you don't need some of the returned value it can be discarded 
             *  by using the underscore symbol helping with the memory storage improvement
             */

            (string WeekDay, _) = GetCurrentWeekDayAndYear();
            Console.WriteLine($"Weekday is {WeekDay} ");
        }

        public static (string day, int year) GetCurrentWeekDayAndYear()
        {
            return (DateTime.Now.DayOfWeek.ToString(), DateTime.Now.Year);
        }
    }
}
