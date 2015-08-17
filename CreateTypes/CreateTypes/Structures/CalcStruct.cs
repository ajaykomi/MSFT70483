using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Structures
{
   public struct CalcStruct
    {
       
       int _a;
       public int A
       {
           get { return _a; }

           set { _a = value; }
       }
       

        public int factorial(CalcStruct cstruct)
        {
            this.A = 5;
            int result = cstruct.A;
            
            while (cstruct.A !=1)
            {
              result = result * (cstruct.A - 1);
              cstruct.A--;
            }
            return result;
        }
    }
}
