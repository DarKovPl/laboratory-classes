using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalsses4LoopsBeginTwelfthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number for the range:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];

            for (int z = 0; z < array.Length; z++)
            {
                array[z] = "X";
                
                if (z != array.Length - 1)
                {
                    for (int f = array.Length - 1; f >= 0; f--)
                    {
                        string output = " ";
                        Console.Write($"{(((z == f) || (f == 0)) ? array[f] : output)}");
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine($"{string.Join("", array)}");
            }

            
            Console.ReadKey();


        }

    }

}
