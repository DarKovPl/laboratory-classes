using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassesLoopsBeginFifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int debt = -80, counter = 0; 
            double j = 50 * 0.2, k = 40 * 0.2, totalDeposit = 0;
            double toClearOfTheDebt = (double)debt;

            do
            {
                counter++;
                totalDeposit += (j + k);
                toClearOfTheDebt += (j + k);
                
                Console.WriteLine("The total amount of the balance: {0}.\nTotal cash deposit so far:  {1}.\nRepayment day: {2}\n", toClearOfTheDebt, totalDeposit, counter);
            
            } while (toClearOfTheDebt <= 0);

            Console.ReadKey();
        }
    }
}
