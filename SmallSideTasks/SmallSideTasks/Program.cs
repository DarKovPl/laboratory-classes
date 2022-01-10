using System;

namespace SmallSideTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number grater than two.");
            int a = Convert.ToInt16(Console.ReadLine());
            

            for(var i = 1; i <= a; ++i)
                if ((i == 1) || (i == a))
                {
                    string stars = new string('*', a);
                    Console.WriteLine(stars);
                }
                else
                {
                    for (int m = 1; m <= a; ++m)
                    {
                        if (m == 1 || m == a)
                        {
                            string star = "*";
                            Console.Write(star);
                        }
                        else
                        {
                            string empty = " ";
                            Console.Write(empty);

                        }
                    }   Console.WriteLine();
                    
                }
            Console.ReadKey();
        }
    }
}
