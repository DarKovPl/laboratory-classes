using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses3LoopsBeginSecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, s = 0;
            for (int i = 1; i <= 10; i++)
            {
                s += n;
                n += 1;
                Console.WriteLine("s: {0}\ni: {1}\nn: {2}\n", s, i, n);

            }
            Console.Write(s);
            Console.ReadKey();


        }
    }
}
