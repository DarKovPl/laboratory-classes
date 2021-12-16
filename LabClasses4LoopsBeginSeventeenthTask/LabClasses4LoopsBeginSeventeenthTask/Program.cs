using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginSeventeenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the constant: ");
            int constant = Convert.ToInt32(Console.ReadLine()), i = 1, j = 2, s = 0;
            for(; i <= constant; i++)
            {
                s += j;
                j += 2;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        
        }
    }
}
