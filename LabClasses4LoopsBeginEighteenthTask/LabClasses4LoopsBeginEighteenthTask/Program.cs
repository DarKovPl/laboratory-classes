using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LabClasses4LoopsBeginEighteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2, s = 0;
            CultureInfo ci = new CultureInfo("pl-pl");
            
            while (i <= 30)
            {
                s += j;
                j += 2;
                i += 1;

            }
            Console.WriteLine(s.ToString("C", ci));
            Console.ReadKey();
        }
    }
}
