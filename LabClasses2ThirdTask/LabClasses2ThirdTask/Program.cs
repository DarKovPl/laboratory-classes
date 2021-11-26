using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price: {0, 20:c}.", 14); //wyrównanie do prawej, z podaniem waluty
            Console.WriteLine("Price: {0, -20:C4}", 14); //wyrównanie do lewej, dokładność 4 miejsca po przecinku




            Console.ReadKey();
        }
    }
}




//static void Main(string[] args)
//{

//    Console.WriteLine("Cena: {0,20:c}.", 14); // wyrównanie do prawej, z podaniem waluty
//    Console.WriteLine("Cena: {0,-20:C4}.", 14); // wyrównanie do lewej, dokładność 4 miejsca po przecinku

//    Console.WriteLine();                        //odstęp
//    Console.WriteLine("Liczby całkowite: {0:D20}", 14);

//    Console.WriteLine("Liczby rzeczywiste:");
//    Console.WriteLine("\tNotacja naukowa {0:e3}", 2.345);
//    Console.WriteLine("\tNotacja naukowa {0:E1}", 2.345);
//    Console.WriteLine("\tNotacja zwykła {0:f12}", 0.000000345);
//    Console.WriteLine("\tNotacja kompaktowa {0:g}", 0.000000345);
//    Console.WriteLine("\tNotacja kompaktowa {0:g}", 23.45e-1);

//    Console.WriteLine();
//    Console.WriteLine("Bez grupowania cyfr: {0}", 3123456.56);
//    Console.WriteLine("Z grupowaniem cyfr: {0:N}", 3123456.56);

//    Console.WriteLine();
//    Console.WriteLine("Liczba szesnastkowa: {0:x}", 23456);
//    Console.WriteLine("Liczba szesnastkowa: {0:X}", 23456);

//    Console.WriteLine();
//    Console.WriteLine("Procenty: {0:P}", 50);

//    Console.WriteLine();
//    Console.WriteLine("Wartość przybliżona: {0:f10}", 123456789.12345678);
//    Console.WriteLine("Wartość dokładna: {0:r}", 123456789.12345678);

//    Console.ReadKey();
//}
