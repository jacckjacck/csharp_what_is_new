using System;

namespace CSHARP_WHAT_IS_NEW
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * OLD WAY}
             * it's necessary to declare a variable 
             */
            //AddDayToCurrentDate(out date);

            /*
             *  NEW WAY
             *  it's possible to declare the out variable in the same instruction 
             */
            AddDayToCurrentDate(out DateTime date);

            Console.WriteLine($"New Date is {date}");
        }

        public static void AddDayToCurrentDate(out DateTime date)
        {
            date = DateTime.Now.AddDays(1);
        }
    }
}
