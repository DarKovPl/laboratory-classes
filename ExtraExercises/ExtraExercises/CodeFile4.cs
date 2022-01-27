using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //32
            Console.WriteLine("Give me the number between 1 and 3: ");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int drawByLot = rnd.Next(1, 3);

            if (chosenNumber == drawByLot)
                Console.WriteLine($"Your number: {chosenNumber} is equal to the computer number: {drawByLot}");
            else
            {
                Console.WriteLine($"No this time. You missed one's aim. Your number: {chosenNumber}. Computer's number: {drawByLot}");
            }
        }
    }
}