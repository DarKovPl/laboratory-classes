using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace SmallSideTasks
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the range of the array: ");
            int number = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[number];
            int v = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Give me the item to array: ");
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(array);
            
            int[] zero = new int[array.Length];
            
            foreach (var item in array)
            {
                if (item == 0)
                    zero[v++] = 1;
                
            }
            // I know that I can .Count 'array' and get multiples zero from that array. This is only exercise.
            int freq = zero.Count(f => (f == 1));
            Console.WriteLine($"Sorted array elements: {string.Join(", ", array)}");
            Console.WriteLine($"Amount of numbers equal zero:  {freq}");
            Console.ReadKey();

        }

    }
}