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
            int i = 1, j = 2, s = 0;

            while(i <= 10)
            {
                s += j;
                j += 2;
                i += 1;

            }
            Console.WriteLine(s);
            Console.ReadKey();

            while( i <= 10)
            {
                s = s + j;
                j = j + 2;
                i = i + 1;

            }
            Console.WriteLine(s);
            Console.ReadKey();
        
        }
        
    }
}
