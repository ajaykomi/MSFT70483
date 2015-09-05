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
            string curdirectory=  Directory.GetCurrentDirectory();
            File.Open(curdirectory, FileMode.OpenOrCreate, FileAccess.Read);
            File.Create(curdirectory,1531, FileOptions.None);

        }
    }
}