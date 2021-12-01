using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int value_1 = 0;
            byte value_2 = 15;

            value_1 = value_2;  // Wymuszona konwersja, dokonywana automatycznie przez kompilator
                                // Przypisanie wartości byte do wartości int

            
            Console.WriteLine(34 + 35.5); // Kolejny przykład, dodajemy dwie liczby: całkowitą i zmiennoprzecinkową
                                          // Wynik to wartość zmiennoprzecinkowa


            double number = 3765.47;
            int i;

            i = (int) number; // Konwersja typu doble na int -użycie operatora rzutowania;
                              // Rezultat wywołania takiego programu to: 3765

            Console.WriteLine(i);

            ExplicitConversion ex = new ExplicitConversion();
            Console.WriteLine(ex.DisplayVariable);           


            Console.ReadKey();


        }
    }
}
