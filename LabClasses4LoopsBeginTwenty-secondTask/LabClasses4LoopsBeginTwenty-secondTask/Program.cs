using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginTwenty_secondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.WriteLine("Give me the a number: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the b number: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------");

            while(a % b != 0)
            {
                r = (a % b);
                a = b;
                b = r;
                if (a % b == 0)
                    Console.WriteLine(b);
            }
            if (r == 0)
                Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
