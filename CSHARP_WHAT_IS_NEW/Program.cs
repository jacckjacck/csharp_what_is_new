using System;

namespace CSHARP_WHAT_IS_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionBodied expressionBodied = new ExpressionBodied("Jhon", "Doe");

            Console.WriteLine($"{expressionBodied.FullName}");
            
            
            //Other way
            //Console.WriteLine($"{new ExpressionBodied("Jhon", "Doe").FullName}");
        }
    }
}
