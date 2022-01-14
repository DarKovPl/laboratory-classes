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
            Console.WriteLine("Give me number grater than zero.");
            uint n = Convert.ToUInt16(Console.ReadLine());
            double result = (1 + Math.Pow(n, 2)) / 2; 

            Console.WriteLine(result);
            Console.ReadKey();

        }

    }
}