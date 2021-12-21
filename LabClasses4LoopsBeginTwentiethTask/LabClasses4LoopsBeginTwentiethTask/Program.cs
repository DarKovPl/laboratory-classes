using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginTwentiethTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 2, s = -10;

            while (i <= 10)
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
