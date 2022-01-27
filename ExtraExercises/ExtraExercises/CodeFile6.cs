using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //34
            // Random rnd = new Random();
            //
            // for(int i = 0; i <= 5; i++)
            //     Console.Write($"{rnd.NextDouble():N2} ");

            //35
            int j = 1;

            Random rnd1 = new Random();

            for (;j <= 5;)
            {
                (double x, double y) = (rnd1.NextDouble(), rnd1.NextDouble());
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(1, 2))
                {
                    Console.WriteLine($"Point: {j}. Coordinate x: {x:N5}. Coordinate y: {y:N5}");
                    j++;
                }

            }
        }
    }
}