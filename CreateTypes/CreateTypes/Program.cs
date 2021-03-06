﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateTypes.Structures;
using CreateTypes.Enums;
using CreateTypes.Constructors;
using CreateTypes.IndexedProperties;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;


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

          
           //Console.WriteLine("Please enter timezone from below");
           //foreach ( var val in Enum.GetValues(typeof(Timezones.MyTimezone)))
           //{
           //    Console.WriteLine(val);
           //}
         
           // Timezones.MyTimezone tz = (Timezones.MyTimezone)Enum.Parse(typeof(Timezones.MyTimezone), Console.ReadLine().ToUpper());
           // switch (tz)
           // {
           //     case Timezones.MyTimezone.EST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Eastern Standard Time"));
           //         break;
           //     case Timezones.MyTimezone.GMT: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Greenwich Standard Time"));
           //         break;
           //     case Timezones.MyTimezone.PST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Pacific Standard Time"));
           //         break;
           //     case Timezones.MyTimezone.CST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Central Standard Time"));
           //         break;
           //     case Timezones.MyTimezone.IST: Console.WriteLine(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "India Standard Time"));
           //         break;
           //     default: Console.WriteLine(DateTime.Now);
           //         break;
                
           // }
           // Console.WriteLine("Converted to: " + tz);
           // Console.Read();
            #endregion

            #region Extension methods
              //string status;
              //FFRestaurant ffres = new FFRestaurant();
              //ffres.ComboID = 1;
              //ffres.Meal = "Chicken Sandwich";
              //ffres.Drink = "Small soda";
              //ffres.Desert = "Vanila Ice Cream";
              //ffres.Price = 8.5M;

              //string sw = ffres.ToTextWriter(out status);
              //Console.WriteLine("FF Resturant class is converted to text file through extension method: \n" + sw +" order is " + status);
          
            #endregion

            #region OverrideMethods


           // string status = string.Empty;
           // FFRestaurant ffr = new FFRestaurant();
           // Console.WriteLine(string.Format("Basic 6 meals price is: {0}" , ffr.CalculatePrice(6, 8.5M)));
           // McDonalds mcd = new McDonalds();

           // Console.WriteLine(string.Format("Discount 6 meals price in Mcdonalds is: {0}", mcd.CalculatePrice(6, 8.5M)));

          
           // List<McDonalds> lstmcd = new List<McDonalds>
           // {
           //     new McDonalds{ ComboID = 1, Desert="milkshake", Drink ="soda", Meal ="chicken burger", Price =7.5M},
           //     new McDonalds {ComboID = 2, Desert ="Ice cream", Drink ="Smoothie", Meal="Wrap", Price= 10}
           // };

           //// foreach loop on list
           // foreach (McDonalds mcmealitem in lstmcd)
           // {
           //     Console.WriteLine(mcmealitem.ToTextWriter(out status )); // used extension method
           // }

            

            #endregion

            #region Constructors
            //Invoking by new kwyword
            BurgerKing bg = new BurgerKing();
            Console.WriteLine(bg._guid);

            var bgtype = typeof(BurgerKing);
            Console.WriteLine("Type of burger king class is: " + bgtype);
            BurgerKing instance = (BurgerKing) Activator.CreateInstance(bgtype);
            Console.WriteLine(instance._guid);

          // Invoking by getting the constructor info but this is not a good way to do sice lesser performance
            var constructor = bgtype.GetConstructor(Type.EmptyTypes);
            var cinstance = constructor.Invoke(new object[0]);
            Console.WriteLine(instance._guid);

            var genericinstance = createinstance<BurgerKing>();
            Console.WriteLine("Instantiating a constructor of type generic: " + genericinstance._guid);
            
            #endregion

            #region Indexed Properties
            CommentDB commentdb = new CommentDB();
           // Console.WriteLine(commentdb[0].blogid + " Comment is  " + commentdb[0].Commenttext + " at " + commentdb[0].Commentdate);
            Console.WriteLine(commentdb["SKU1234"]);

            #endregion

        }

      public static T createinstance<T>() where T: new()
      {
          return new T();
      }
        
    }
}
