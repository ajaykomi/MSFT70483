using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Enums
{

    // Enums are value types too. Enums are veryhandy when you declare some set of constants
    //Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. 
    //However, an enum can also be nested within a class or struct.

    // Best to learn more on Enum class and it s methods, Enum.parse is most widely used method
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
