using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //27
            Console.WriteLine("Give me integer 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Give me integer 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Give me integer 'c': ");
            int c = Convert.ToInt32(Console.ReadLine());

            int highest = (a > b && a > c) ? a : (b > c) ? b : c;
            string name = (a > b && a > c) ? "a" : (b > c) ? "b" : "c";


            Console.WriteLine($"a = {a}, b = {b}, c = {c}. The highest number between them is '{name}': {highest}");
        }
    }
}
