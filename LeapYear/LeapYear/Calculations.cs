using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Calculations
    {
        public static bool IsLeapyear(ushort year)
        {    
            
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {   
                return true;
            }
            
            else
            {
                return false;
            }

        }
    }
}
