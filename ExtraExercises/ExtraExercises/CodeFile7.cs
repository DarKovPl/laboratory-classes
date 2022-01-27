using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //37

            // int[] array = new int[5]; 
            //
            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumbers = Convert.ToInt32(Console.ReadLine());
            //     array[i] = userNumbers;
            //
            // }
            // array.ToList().ForEach(Console.Write);
            // Console.ReadKey();



            //38
            // int[] array = new int[5];
            //
            // for (int i = 4; i >= 0; i--)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumbers = Convert.ToInt32(Console.ReadLine());
            //     array[i] = userNumbers;
            //
            // }
            // array.ToList().ForEach(Console.Write);
            // Console.ReadKey();


            //39
            // int[] array = new int[5];
            //
            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumber = Convert.ToInt32(Console.ReadLine());
            //     if (userNumber > 3)
            //         array[i] = userNumber;
            //
            // }
            // int res = array.Count(x => x != 0);
            //
            // Console.Write(res);
            // Console.ReadKey();



            //40
            // int[] array = new int[5];
            //
            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumber = Convert.ToInt32(Console.ReadLine());
            //     array[i] = userNumber;
            //
            // }
            // Console.WriteLine("Give the number to compare with the number array.");
            // int toCompare = Convert.ToInt32(Console.ReadLine());
            //
            // foreach(int item in array)
            //     if (item == toCompare)
            //         Console.WriteLine($"The number: {item} is in the array and is equal to an extra number."); 
            //     else Console.WriteLine("Additional number is not in array.");
            // Console.ReadKey();




            //41
            // int[] array = new int[5];
            //
            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumber = Convert.ToInt32(Console.ReadLine());
            //     array[i] = userNumber;
            //
            // }
            //
            // int minNumber = array.Min();
            // int indexOfANumber = Array.IndexOf(array, minNumber);
            //
            // Console.WriteLine($"The smallest number: {minNumber} and the index: {indexOfANumber}");
            //
            // Console.ReadKey();


            //42
            // int[] array = new int[5];
            //
            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine("Give me the number: ");
            //     int userNumber = Convert.ToInt32(Console.ReadLine());
            //     array[i] = userNumber;
            //
            // }
            //
            // int maxNumber = array.Max();
            // int indexOfANumber = Array.IndexOf(array, maxNumber);
            //
            // Console.WriteLine($"The biggest number: {maxNumber} and the index: {indexOfANumber}");
            //
            // Console.ReadKey();

            //43
            int[] array = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Give me the number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                array[i] = userNumber;

            }

            int maxNumber = array.Max();
            int minNumber = array.Min();
            int indexOfMaxNumber = Array.IndexOf(array, maxNumber);
            int indexOfMinNumber = Array.IndexOf(array, minNumber);
            Console.WriteLine($"The biggest number: {maxNumber} and the index: {indexOfMaxNumber}. The smallest number: {minNumber} and the index: {indexOfMinNumber}");

            Console.ReadKey();

        }
    }
}