using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> strList = new List<string>();
            string sample = "The dynamic type enables the operations in which it occurs to bypass compile-time type checking. Instead, these operations are resolved at run time";
            string[] strsample = sample.Split(' ');
            foreach (string sptstring in strsample )
            {
                strList.Add(sptstring);
            }
            string[] strarray = new string[]{"When", "Where","How"};
            
            Console.WriteLine(string.Join("; ", strarray));  // join example
            Console.WriteLine(string.Join(";", strList.ToArray())); // join and toarray example
            Console.WriteLine(String.Concat(Players.dravid, Players.sachin)); // concat example
            Console.WriteLine(sample.ToUpperInvariant());
            Console.WriteLine(strsample.Aggregate((work,next)=> (next +' '+ work))); // aggregate extension methods
            Console.ReadKey();
            
        }
    }
}
