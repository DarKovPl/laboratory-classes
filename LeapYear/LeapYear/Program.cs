using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // uzytkownik podaje rok
            // program zwraca wartosc true  o ile rok jest przestepny
            Console.WriteLine("Enter the year");
            ushort year = Convert.ToUInt16(Console.ReadLine());

            bool answer = Calculations.IsLeapyear(year);
            Console.WriteLine("Is the year {0} its leap year? {1}", year, answer);
            
            Console.WriteLine(Calculations.IsLeapyear(2020));   //True
            Console.WriteLine(Calculations.IsLeapyear(2021));   //False
            Console.WriteLine(Calculations.IsLeapyear(2000));   //True
            Console.WriteLine(Calculations.IsLeapyear(1900));   //False
            Console.ReadKey();
        }
    }
}
