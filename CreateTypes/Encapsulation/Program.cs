using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation.Classes;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Blogs bloginstance = new Blogs(1231654);

            bloginstance.blogger = "ajay"; // internal
            bloginstance.blogpost = "some thing about C sharp"; // public
            bloginstance.rating = 5; // public
        }
    }
}
