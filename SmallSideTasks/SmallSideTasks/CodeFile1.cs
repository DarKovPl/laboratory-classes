using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SmallSideTasks
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many natural numbers divided by 11 and NOT divided by 3 do you want to see?");
            int howMany = Convert.ToInt16(Console.ReadLine());
            int counter = 0;

            while (howMany > 0)
            {
                

                int naturalNumDivided = ((counter % 11 == 0) && (counter % 3 != 0)) ? counter : -1;
                counter++;

                if (naturalNumDivided != -1)
                {
                    Console.WriteLine(naturalNumDivided);
                    howMany--;
                }
            }

            Console.ReadKey();

        }

    }
}