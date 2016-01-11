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


        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnCurrentDir_Click(object sender, EventArgs e)
        {
            string curdirectory = Directory.GetCurrentDirectory();
            lblMessage.Text = curdirectory;
            string filepath = Path.Combine("C:\\", txtfileName.Text);

            File.WriteAllText(filepath, txtComments.Text);
            //if (!File.Exists(filepath))
            //{
            //    File.Create(filepath);
            //    File.WriteAllText(filepath, txtComments.Text);
            //}
        }
    }
}