using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginFourteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            
            while (condition)
            {
                var timeString = DateTime.Now.ToString("hh:mm:ss");
                
                Console.WriteLine(timeString);
                Console.WriteLine("Do you want to see current time one more time? Press any key for yes or 'n' for no. And then hit the enter key..");
                
                string n = Convert.ToString(Console.ReadLine());
                condition = (n == "n" ? false : true);
            }
        }
    }
}
