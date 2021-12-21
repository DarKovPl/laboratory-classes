using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeginEleventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number for the range:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0;  array.Length > i; i++)
            {
                array[i] = "X";
                
                List<string> listOfStrings = array.ToList();
                List <string> reverse = Enumerable.Reverse(listOfStrings).ToList();
                
                foreach(string item in reverse)
                
                    Console.Write($"{(item == null ? " " : item)}");
                
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
