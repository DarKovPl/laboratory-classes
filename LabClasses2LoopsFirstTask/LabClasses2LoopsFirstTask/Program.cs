using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2LoopsFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C# is easy!!!";
            int z = 0, a = 1,  sum = 0;


            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(sentence + i);
            }
            
            Console.ReadKey();

            while (z <= 100)
            {
                Console.WriteLine(sentence + z);
                z++;

            }
            Console.ReadKey();

            for(; a <= 10; a++)
            {
                sum += a;
                Console.WriteLine(sum);
            }

            Console.ReadKey();
            
            
            int b = 1;
            while (b <= 100)
            {
                b += 2;
                Console.WriteLine("{0}, ", b);
            }

            Console.ReadKey();
        }

    }
}
