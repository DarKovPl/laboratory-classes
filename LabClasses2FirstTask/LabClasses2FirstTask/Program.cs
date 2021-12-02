using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2FirstTask
{
    class Program
    {

        enum YearSeasons : byte { Spring, Summer, Winter, Autumn }
        
        static void Main(string[] args)
        {
            YearSeasons season;
            Console.WriteLine("\t0 - Spring\n\t1 - Summer\n\t2 - Winter\n\t3 - Autumn" + "\n\n");

            Console.WriteLine("Give me your favourite season: ");
            int i = Convert.ToInt32(Console.ReadLine());
            season = (YearSeasons)i;
            Console.WriteLine("Your favourite season is: {0}\n\n", season);

            Console.WriteLine("Now give me your most disliked season: ");
            int z = Convert.ToInt32(Console.ReadLine());
            season = (YearSeasons)z;
            Console.WriteLine("Your most disliked season is: {0}", season);
            
            
            Console.ReadKey();
        }
    }
}
