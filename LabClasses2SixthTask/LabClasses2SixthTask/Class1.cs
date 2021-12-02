using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses2SixthTask
{
    class ExplicitConversion
    {

        short s = 300;
        byte b;
        
        public byte DisplayVariable
        {
            get
            {
                //byte b = s; //błąd, musi być konwersja jawna byte 
                return b = (byte)s;
            }
            
            
        }
    }
}
