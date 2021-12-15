using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginThirteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -10;
            
            Console.WriteLine("Give me a:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Give me b:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("  x | y");
            
            while (x <= 10)
            {
                int y = a * x + b;
                Console.WriteLine("{0,3} | {1,2}", x, y);

                x += 1; 
                
            }
            Console.ReadKey();
        }
    }
}
