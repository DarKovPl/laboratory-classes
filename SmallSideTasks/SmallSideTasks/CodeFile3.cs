using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace SmallSideTasks
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the a number:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give me the b number:");
            int b = Convert.ToInt16(Console.ReadLine());
            
            int result = a + b;

            if (result == 0)
                Console.WriteLine("The result of adding two numbers a and b is zero. '0'");
            else
            {
                string negativeOrPositiveResult = ((result > 0) ? "positive '+'" : "negative '-'");
                Console.WriteLine($"The result of adding two numbers a and b is {negativeOrPositiveResult}");
            }
            Console.ReadKey();

        }

    }
}