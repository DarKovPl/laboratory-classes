using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //30
            for (int i = 65; i <= 90; i++)
            {
                Console.Write($"{(char)i}");
            }
            Console.WriteLine();

            //31
            for (int i = 90; i >= 65; i--)
            {
                Console.Write($"{(char)i}");
            }
        }
    }
}