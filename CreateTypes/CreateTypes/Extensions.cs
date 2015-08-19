using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CreateTypes
{
    public static class Extensions
    {
        //Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 
        //Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type

        public static string Writetext(this string val)
        {
            return "return value";
        }

        public static String ToTextWriter<T>(this T obj, out string outstatus)
        {
            StringWriter textWriter = new StringWriter();
            string strstatus = string.Empty;
            using (textWriter)
            {
                textWriter.Write(JsonConvert.SerializeObject(obj).Replace(",", Environment.NewLine));
            }
            if (!string.IsNullOrEmpty(textWriter.ToString()))
            {
                strstatus = "success";
            }
            outstatus = strstatus;
            return textWriter.ToString().Replace("{", "").Replace("}", "");
            
        }

    }


}
