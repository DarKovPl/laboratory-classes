using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses3LoopsBeginFourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a < b)
                while (a <= b)
                {
                    if ( a % 2 == 0)
                    {
                        Console.WriteLine(a);
                    }
                    a += 1;
                }
            else
            {
                while (a >= b)
                {
                    if (b % 2 == 0)
                    {
                        Console.WriteLine(b);
                    }
                   
                    b += 1;
                }
            }
            Console.ReadKey();
        }
    }
}
