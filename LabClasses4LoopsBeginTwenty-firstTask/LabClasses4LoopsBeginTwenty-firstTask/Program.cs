using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginTwenty_firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the b number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

            while (a != b)
            {
                Console.WriteLine("{0}", a);

                if (a > b)
                {
                    a -= b;
                }

                else
                {
                    b = b - a;
                }
            }
            // Console.WriteLine("NWD: {0}", a); In the task there is no mention of writing NWD on the console.
            Console.ReadKey();
        }   
    }
}
