using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateTypes.Structures;

namespace CreateTypes
{
    class Program
    {
      public static void Main(string[] args)
        {
          // struct is same as class but it is value type. When a struct is initialized its value will be initialized rather than just reference. 
          // Just keep in mind that they're created on the stack and that you're not dealing with references to them but dealing directly with them. 
          //Whenever you have a need for a type that will be used often and is mostly just a piece of data, structs might be a good option.

            CalcStruct cs = new CalcStruct();
            CalcClass cc = new CalcClass();
            cs.A = 6;
            cc.A = 6;
            Console.WriteLine( "factorial of 6 in struct:" +cs.factorial(cs)); //  this gives 720
            Console.WriteLine("factorial of 6 in class:" + cc.factorial(cc)); // This gives 120
            Console.Read();
        }
    }
}
