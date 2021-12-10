using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassesLoopsBeginSeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number for the divide: ");
            byte a = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Give me the divisor: ");
            byte b = Convert.ToByte(Console.ReadLine());
            
            List<string> divisorList = new List<string>();
            if (a % b == 0)
            {
                Console.WriteLine("Number {0} is a divisor of number {1}.\n", b, a);
                
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                        divisorList.Add(i.ToString());
                }
                
                string[] divisorArray = divisorList.ToArray();
                Console.WriteLine("All divisors of number {0}: " + String.Join(" ", divisorArray), a);
            }
            Console.ReadKey();

        }
    }
}
