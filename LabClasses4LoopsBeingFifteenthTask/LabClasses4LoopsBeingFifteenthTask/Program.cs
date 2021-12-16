using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses4LoopsBeingFifteenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the positive number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
             if(i == n)
                for (int z = 1; z <= i; z++)
                    {
                       
                        string x = "X";
                        string o = "O";
                        int multiply = n / 2;
                        string output = string.Concat(Enumerable.Repeat($"{(z % 2 != 0 ? x + o : o + x)}", multiply));
                        
                        Console.WriteLine((n % 2 != 0 ? (z % 2 != 0 ? output + x : output + o) : (z % 2 != 0 ? output : output)));
                    }
                
            }
            Console.ReadKey();
            

        }
    }
}
