using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                float x;
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                float y;
                y = Convert.ToInt32(Console.ReadLine());

                //float average = (x + y) / 2;
                float average;
                average = Convert.ToSingle((x + y) / 2);

                Console.WriteLine("The mean of the first number is {0}, the second is {1} and the average of two number is {2}", x, y, average);
                Console.ReadKey();
            }
            catch (Exception handle)
            {
                Console.WriteLine(handle.Message);
                Console.ReadKey();
            }
        }
    }
}