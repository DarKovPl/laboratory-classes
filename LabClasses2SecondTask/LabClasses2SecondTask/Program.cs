using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enum type ConsoleColor is for changing colour change.\n\n");
            Console.WriteLine("Text before colour changed.");
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("Text after colour changed.\n\n");

            Console.WriteLine("Text before colour changed.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Text after colour changed.");


            Console.ReadKey();
        }
    }
}


//static void Main(string[] args)
//{
//    Console.WriteLine("Typ wyliczeniowy ConsoleColor służy do zmiany koloru konsoli");
//    //Zmiana koloru tła tekstu
//    Console.BackgroundColor = ConsoleColor.Blue;
//    //Kolor czcionki
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine("Tekst po zmianie koloru");

//    Console.ReadKey();
//}
