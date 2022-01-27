using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //44
            // Console.WriteLine("Give me the positive natural number: ");
            // uint n = Convert.ToUInt32(Console.ReadLine());
            //
            // Console.WriteLine("Give me the positive natural number: ");
            // uint k = Convert.ToUInt32(Console.ReadLine());
            //
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < k; j++)
            //         Console.Write("*");
            //     Console.WriteLine();
            // }


            //45
            // Console.WriteLine("Give me the positive natural number: ");
            // uint n = Convert.ToUInt32(Console.ReadLine());
            //
            // for (int i = 1; i <= n; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //         Console.Write("*");
            //     Console.WriteLine();
            // }

            //46

            Console.Write("Enter number: ");

            int num = Convert.ToInt32(Console.In.ReadLine());

            for (int i = -1; i < num; i++)
            {

                for (int j = num - i; j > 0; j--)
                
                    Console.Write(" ");

                for (int j = 0; j <= i; j++)

                    Console.Write("*" + "*");

                Console.WriteLine();



            }
        }
    }
}