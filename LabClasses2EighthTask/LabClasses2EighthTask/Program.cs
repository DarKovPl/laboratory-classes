using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2EighthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division by zero. No compilation.
            //int X;
            //X = 10 / 0;

            //Division by zero. Exception occurred. 
            //int x, y, z;
            //x = 10;
            //y = 0;
            //z = x / y;

            int x, y, z;
            x = 10;
            y = 0;
            try
            {
                z = x / y;
            }
            catch
            {
                Console.WriteLine("Don't try to divide by zero.");
            }
            finally
            {
                Console.WriteLine("Code from the block of finally.");
            }

            Console.WriteLine("Hit the key.");
            Console.ReadKey();

            double divisor, quotient;
            try
            {
                Console.WriteLine("Give me a number: ");
                divisor = Convert.ToDouble(Console.ReadLine());
                if (divisor == 0)
                    throw new DivideByZeroException("The divisor can't be zero.");
                quotient = 10.2 / divisor; 
                Console.WriteLine(divisor);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception message: {0}", e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
