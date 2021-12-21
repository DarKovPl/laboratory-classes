using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses3LoopsBeginNinthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the range: ");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0, z = 0;
            int[] array = new int[n];

            for (;array.Length > z; i++)
            {
                if (i % 2 != 0) 
                {
                    array[z++] = i;

                    string text = String.Join("+", array);
                    Console.WriteLine(text);
                    
                    if (array.Length <= z)
                        Console.WriteLine(text + "=" + Convert.ToString(array.Sum()));
                    
                    Console.ReadKey();
                }
                
            }
            Console.ReadKey();
        }
    }
}
