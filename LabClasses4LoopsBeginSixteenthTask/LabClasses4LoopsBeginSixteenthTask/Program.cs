using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginSixteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program is able to count the sum of two variables (s + j) and additionally, one of them "j" is increased by 2 in every loop.
            // At the end, the variable "s" is printed on the screen. Variable "i" is the counter in this application.

            int i = 1, j = 2, s = 0;

            while(i <= 10)
            {
                s += j;
                j += 2;
                i += 1;

            }
            Console.WriteLine(s);
            Console.ReadKey();
        
        }
        
    }
}
