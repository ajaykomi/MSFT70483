using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Enums
{
   
   public class Timezones
    {
       [Flags]
       public enum MyTimezone
       {
           GMT,
           EST,
           CST,
           PST,
           IST
       }        
    }
}
