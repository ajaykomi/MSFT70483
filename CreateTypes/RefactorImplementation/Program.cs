using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Encapsulation.Classes;
using System.Drawing;
using RefactorImplementation.Models;
using RefactorImplementation.RulesEngine;


namespace RefactorImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicRefactoring
            //Type t = typeof(Blogs);
            //Blogs firstblog = new Blogs();
            //string firstbyte = "just checking";

            //Console.WriteLine(t);
            //PropertyInfo[] allprops =  t.GetProperties();

            //foreach (PropertyInfo p in allprops)
            //{
            //    Console.WriteLine(p);
            //}
            // MethodInfo[] allmethods =  t.GetMethods();
            // foreach (MethodInfo m in allmethods)
            // {
            //     Console.WriteLine(m);
            // }
            #endregion

            #region Refactoring and Attributes

            Registration registration = Activator.CreateInstance<Registration>();
            IRuleEngine<Registration> rulengine = new DefaultRuleEngine<Registration>();

            registration.Userneme = "bsdjkfljbnfklbhfibuhjknksfd";
            registration.Email = "Someemail.com";

            List<BrokenRule> results = rulengine.Validate(registration);
            foreach (BrokenRule result in results)
            {
                Console.WriteLine("The broken role is: " +result.Name + " Error Message is " + result.ErrorMessage);
            }
            Console.ReadLine();

            #endregion

            //byte[] imagebytes = (byte[])(new ImageConverter().ConvertTo(firstbyte , typeof(byte)));

            //Console.WriteLine(imagebytes);
        }

    }
}
