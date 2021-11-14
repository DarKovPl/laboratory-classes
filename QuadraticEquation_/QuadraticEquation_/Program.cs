using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number a: ");
                float a;
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number b: ");
                float b;
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number c: ");
                float c;
                c = Convert.ToInt32(Console.ReadLine());

                float delta;
                delta = Convert.ToSingle(Math.Pow(b, 2) - 4 * a * c);

                Console.WriteLine("From factors: a:{0}, b:{1}, c:{2} delta is {3} ", a, b, c, delta);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
