using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Structures
{
    struct Calc
    {

        public static int factorial(int number)
        {
            int result = number;
            while (number !=1)
            {
              result =  result *  (number - 1);
                number--;
            }
            return result;
        }
    }
}
