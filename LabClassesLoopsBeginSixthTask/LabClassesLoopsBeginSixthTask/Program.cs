using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassesLoopsBeginSixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of rows and columns.");
            int rectangle = Convert.ToInt32(Console.ReadLine());
            string star = new string('*', rectangle);
            
            for (int i = 1; i <= rectangle; i++)
                Console.WriteLine(star);
            
            Console.ReadKey();    
        }
        
    }
}
