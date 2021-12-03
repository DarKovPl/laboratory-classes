using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2TenthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int season;
            Console.Write("Give me the season's number: ");
            season = Convert.ToInt16(Console.ReadLine());
            switch(season)
            {
                case 1: Console.WriteLine("Spring"); break;
                case 2: Console.WriteLine("Summer"); break;
                case 3: Console.WriteLine("Autumn"); break;
                case 4: Console.WriteLine("Winter"); break;
                default: Console.WriteLine("There is no season like this."); break;

            }
            Console.ReadKey();
        }
    }
}
