using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2NinthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, x, y;
            
            Console.WriteLine("Give me first number: ");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Give me second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                z = x * y;
                Console.WriteLine("First number: {0}. Second number: {1}. Factors x and y are smaller than zero and were multiplied. Result: {2} ", x, y, z);
            }
            else if (x == 0 | y == 0)
            {
                z = 10;
                Console.WriteLine("First number: {0}. Second number: {1}. Factors x or y is smaller than zero. Result: {2} ", x, y, z);
            }

            else
            {
                z = y + x;
                Console.WriteLine("First number: {0}. Second number: {1}. Numbers x and y are bigger than zero and were added. Result: {2} ", x, y, z);
            }

            Console.ReadKey();
        }
    }
}
