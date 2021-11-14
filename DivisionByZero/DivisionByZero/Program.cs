using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double divisor, quotient;

            try
            {
                Console.WriteLine("Type divisor here: ");
                divisor = Convert.ToDouble(Console.ReadLine());
                
                if (divisor == 0)
                    throw new DivideByZeroException("Division by zero is unacceptable");
                
                quotient = 7.8 / divisor;
                Console.WriteLine(quotient);    
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception message: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception message: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
