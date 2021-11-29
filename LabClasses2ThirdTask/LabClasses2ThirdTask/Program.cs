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
            Console.WriteLine("Price: {0, 20:c}.", 14); //wyrównanie do prawej, z podaniem waluty: Price:               £14.00.
            Console.WriteLine("Price: {0, -20:C4}\n", 14); //wyrównanie do lewej, dokładność 4 miejsca po przecinku: Price: £14.0000
            Console.WriteLine("Liczby całkowite: {0:d20}", 14);  //Liczby calkowite: 00000000000000000014
            
            Console.WriteLine("Liczby rzeczywiste:");
            Console.WriteLine("\tNotacja naukowa {0:e3}", 2.345); //Notacja naukowa 2.345e+000
            Console.WriteLine("\tNotacja naukowa {0:E1}", 2.345); //Notacja naukowa 2.3E+000
            Console.WriteLine("\nNotacja zwykła {0:f12}", 0.000000345); //Notacja zwykla 0.000000345000
            Console.WriteLine("\tNotacja kompaktowa {0:g}", 0.000000345); //Notacja kompaktowa 3.45e-07
            Console.WriteLine("\tNotacja kompaktowa {0:g}\n", 23.45e-1); //Notacja kompaktowa 2.345

            Console.WriteLine("Bez grupowania cyfr: {0}", 3123456.56); //Bez grupowania cyfr: 3123456.56
            Console.WriteLine("Z grupowaniem cyfr: {0:N}\n", 3123456.56); //Z grupowaniem cyfr: 3,123,456.56

            Console.WriteLine("Liczba szesnastkowa: {0:x}\n", 23456); //Liczba szesnastkowa: 5ba0

            Console.WriteLine("Procenty: {0:P}\n", 50); //Procenty: 5,000.00%

            Console.WriteLine("Wartość przybliżona: {0:f10}", 123456789.12345678); //Wartosc przyblizona: 123456789.1234570000
            Console.WriteLine("Wartośc dokładna: {0:r}\n", 123456789.12345678); //Wartosc dokladna: 123456789.12345678

            Console.WriteLine("Liczba PI w notacji naukowej z trzema miejscami po przecinku {0:e3}", Math.PI); //3.142e+000

            Console.ReadKey();
        }
    }
}
