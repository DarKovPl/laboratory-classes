using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //33
            for (int i = 0; i <= 9; i++)
            {
                Random rnd = new Random();
                int drawByLot = rnd.Next(1, 10);
                Console.WriteLine(drawByLot);
            }
        }
    }
}