using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Encapsulation.Classes;
using System.Drawing;


namespace RefactorImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Blogs);
            Blogs firstblog = new Blogs();
            string firstbyte = "just checking";

            Console.WriteLine(t);
            PropertyInfo[] allprops =  t.GetProperties();

            foreach (PropertyInfo p in allprops)
            {
                Console.WriteLine(p);
            }
             MethodInfo[] allmethods =  t.GetMethods();
             foreach (MethodInfo m in allmethods)
             {
                 Console.WriteLine(m);
             }
            
            byte[] imagebytes = (byte[])(new ImageConverter().ConvertTo(firstbyte , typeof(byte)));

            Console.WriteLine(imagebytes);
        }

    }
}
