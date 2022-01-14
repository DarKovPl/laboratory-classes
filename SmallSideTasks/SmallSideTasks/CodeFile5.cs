using System;
using System.Linq;

namespace SmallSideTasks
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number: ");
            string a = Convert.ToString(Console.ReadLine());
            Int64 result = 0;
            
            foreach (var character in a)
            {
                result += Int32.Parse(character.ToString());
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}