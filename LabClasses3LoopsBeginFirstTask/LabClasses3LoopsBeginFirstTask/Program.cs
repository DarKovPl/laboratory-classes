using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses3LoopsBeginFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, s = 0;

            while (i <= 10)
            {
                s += i;
                i += 1;
                Console.WriteLine("s: {0}\ni: {0}\n", s, i);

            }
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
