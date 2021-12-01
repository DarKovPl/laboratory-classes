using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2SeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a = a + 1;
            Console.WriteLine(a);

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            Console.WriteLine(++c);

            int d = 10;
            Console.WriteLine(d++);

            int i = 0;
            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));


            Console.ReadKey();
        }
    }
}
