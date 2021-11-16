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
            bool condition = true;
            
            while (condition)
            
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

                        Console.WriteLine("Factors: a={0}, b={1}, c={2}.\nDelta={3}.\nX1={4}\nX2={5} ", a, b, c, delta, x_1, x_2);
                        Console.ReadKey();
                        condition = false;
                    }
                    
                    else
                    {
                        x_0 = -b / (2 * a);
                        Console.WriteLine("Factors: a={0}, b={1}, c={2}.\nDelta={3}.\nX1 and X2 are equals: {4}", a, b, c, delta, x_0);
                        Console.ReadKey();
                        condition = false;
                    }
                }

                else
                {
                    Console.WriteLine("Delta is below zero ({0}), and there are no square roots in this equation.", delta);
                    Console.ReadKey();
                    condition = false;
                }
                
            }
            
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the key");
                Console.ReadKey();
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                condition = false;
            }
        }
    }
}
