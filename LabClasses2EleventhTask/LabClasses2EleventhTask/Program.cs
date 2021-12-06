using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2EleventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            double center_x = 0, center_y = 0, radiusOfCycle = 5;

            Console.Write("Give me the coordinate x: \n");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Give me the coordinate y: \n");
            y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y));

            Console.Write("Distance between point ({0}, {1}) to the center of the circle ({2}, {3}) is {4, 4:G4}\n", x, y, center_x, center_y, distance);

            if (distance <= radiusOfCycle)
                Console.WriteLine("The point ({0}, {1}) is in the circle. The middle of the circle is in the point (0, 0), and the radius is 5.", x, y);
            else
                Console.WriteLine("The point ({0}, {1}) is not in the circle.", x, y);
            
            Console.ReadKey();
        
        }
    }
}
