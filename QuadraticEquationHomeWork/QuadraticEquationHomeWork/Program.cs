using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c;
            double delta, x_0, x_1, x_2;

            try
            {
                Console.WriteLine("Enter the number a: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    throw new ArithmeticException("The coefficient must be different than zero. Let's try again...");
                }

                Console.WriteLine("Enter the number b: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number c: ");
                c = Convert.ToInt32(Console.ReadLine());

                delta = Convert.ToSingle(Math.Pow(b, 2) - 4 * a * c);

                if (delta >= 0)
                {
                    if (delta > 0)
                    {
                        x_1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x_2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        Console.WriteLine("From factors: a:{0}, b:{1}, c:{2} delta is {3}. X1={4} and X2={5} ", a, b, c, delta, x_1, x_2);
                        Console.ReadKey();
                    }
                    
                    else
                    {
                        x_0 = -b / (2 * a);
                        Console.WriteLine("From factors: a:{0}, b:{1}, c:{2} delta is {3}. X1 and X2 are equals: {4}", a, b, c, delta, x_0);
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("Delta is below zero ({0}) and there is no square roots in this equation", delta);
                    Console.ReadKey();
                }
                
            }
            
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
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
