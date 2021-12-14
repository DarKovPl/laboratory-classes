using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginTenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of range: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("\n");

                for (int z = 1; z <= i; z++)
                    
                    Console.Write("{0,4}", i * z);
            
            }

            Console.ReadKey();
        }
    }
}
