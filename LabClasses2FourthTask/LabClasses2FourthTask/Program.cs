using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Give me the first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give me the second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give me the third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a <= b) && (a <= c))
                Console.WriteLine("Number {0} is the smallest.", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Number {0} is the smallest.", b);
            else
                Console.WriteLine("Number {0} is the smallest.", c);

            Console.WriteLine();

            if ((a >= b) && (a >= c))
                Console.WriteLine("Number {0} is the biggest.", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Number {0} is the biggest.", b);
            else
                Console.WriteLine("Number {0} is the biggest.", c);
           
            Console.ReadKey();

        }
    }
}
