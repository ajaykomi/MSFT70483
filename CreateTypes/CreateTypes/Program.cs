using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateTypes.Structures;
using CreateTypes.Enums;

namespace CreateTypes
{
    class Program
    {
      public static void Main(string[] args)
        {
            #region Structs
            // struct is same as class but it is value type. When a struct is initialized its value will be initialized rather than just reference. 
            // Just keep in mind that they're created on the stack and that you're not dealing with references to them but dealing directly with them. 
            //Whenever you have a need for a type that will be used often and is mostly just a piece of data, structs might be a good option.

            //CalcStruct cs = new CalcStruct();
            //CalcClass cc = new CalcClass();
            //cs.A = 6;
            //cc.A = 6;
            //Console.WriteLine("factorial of 6 in struct:" + cs.factorial(cs)); //  this gives 720
            //Console.WriteLine("factorial of 6 in class:" + cc.factorial(cc)); // This gives 120
            //Console.Read();
            #endregion

            #region Enums

           // Enums are value types too. Enums are veryhandy when you declare some set of constants
           //Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. 
           //However, an enum can also be nested within a class or struct.
           Console.WriteLine("Please enter timezone from below");
           foreach ( var val in Enum.GetValues(typeof(Timezones.MyTimezone)))
           {
               Console.WriteLine(val);
           }
          // Best to learn more on Enum class and it s methods, Enum.parse is most widely used method
            Timezones.MyTimezone tz = (Timezones.MyTimezone)Enum.Parse(typeof(Timezones.MyTimezone), Console.ReadLine().ToUpper());
            switch (tz)
            {
                case Timezones.MyTimezone.EST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Eastern Standard Time"));
                    break;
                case Timezones.MyTimezone.GMT: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Greenwich Standard Time"));
                    break;
                case Timezones.MyTimezone.PST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Pacific Standard Time"));
                    break;
                case Timezones.MyTimezone.CST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Central Standard Time"));
                    break;
                case Timezones.MyTimezone.IST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "India Standard Time"));
                    break;
                default: Console.WriteLine(DateTime.Now);
                    break;
                
            }
            Console.WriteLine("Converted to: " + tz);
            Console.Read();
            #endregion


        }

        
    }
}
