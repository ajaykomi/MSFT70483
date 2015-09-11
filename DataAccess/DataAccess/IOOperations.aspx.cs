using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace DataAccess
{
    public partial class IOOperations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string writetotext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sit amet magna.";
            string curdirectory=  Directory.GetCurrentDirectory();
            string cdirectory = @"C:\MyProjects";
           string path =  Path.Combine(cdirectory, "textfile1.txt");

            var user = System.Security.Principal.WindowsIdentity.GetCurrent().User;
            var userName = user.Translate(typeof(System.Security.Principal.NTAccount));
            StreamWriter sw = new StreamWriter(path, true);
            using (sw)
            {
                 sw.WriteLine(writetotext);

            }
           
            //File.Open(cdirectory, FileMode.OpenOrCreate, FileAccess.Read);
            //File.Create(curdirectory,1531, FileOptions.None);

        }
    }
}