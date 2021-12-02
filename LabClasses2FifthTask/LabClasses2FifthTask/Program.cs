using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max;

            Console.Write("Give me the first value: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give me the second value: ");
            b = Convert.ToInt32(Console.ReadLine());

            max = a > b ? a : b;
                Console.Write("The maximum value is: {0}\n", max);

            if (a > b)
                Console.Write("A is the highest number: {0}", max);
            else
                Console.Write("B is the highest number: {0}", max);


            Console.ReadKey();

        }
    }
}
