using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses3LoopsBeginThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 1, s = 0, i = 1;
            
            Console.WriteLine("Give me the number, please");
            int z = Convert.ToInt32(Console.ReadLine());
            
            for (; i <= z; i++)
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
