using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassesLoopsBeginEighthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the range of division: ");
            byte howMeny = Convert.ToByte(Console.ReadLine()), stop = 0;

            List<string> divisionList = new List<string>();


            for (int i = 0; ; i++)
            {

                if (i == 0)
                {
                    divisionList.Add(i.ToString());
                }
            
                else if (i % 7 == 0)
                {
                    stop += 1;
                    
                    if (stop >= howMeny)
                    {
                        break;
                    }
                    
                    divisionList.Add(i.ToString());
                }

            }
            string[] divisionArray = divisionList.ToArray();
            Console.WriteLine("All numbers can be divided by seven: " + String.Join(", ", divisionArray));
            Console.ReadKey();
        }
    }
}
