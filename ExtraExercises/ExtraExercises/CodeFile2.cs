using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //29
            Console.WriteLine("Give me integer 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me integer 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me integer 'c': ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me integer 'd': ");
            int d = Convert.ToInt32(Console.ReadLine());

            int highest = ((a > b) && (a > c) && (a > d)) ? a : (b > c &&  b > d) ? b : (c > d) ? c : d;
            string name = ((a > b) && (a > c) && (a > d)) ? "a" : (b > c && b > d) ? "b" : (c > d) ? "c" : "d";

            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d} . The highest number between them is '{name}': {highest}");
        }
    }
}