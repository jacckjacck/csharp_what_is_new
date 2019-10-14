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
             *  it's possible to return multiple values from a method
             */

            (string WeekDay, int Year) = GetCurrentWeekDayAndYear();
            Console.WriteLine($"Weekday is {WeekDay} and year is {Year}");
        }

        public static (string day, int year) GetCurrentWeekDayAndYear()
        {
            return (DateTime.Now.DayOfWeek.ToString(), DateTime.Now.Year);
        }
    }
}
