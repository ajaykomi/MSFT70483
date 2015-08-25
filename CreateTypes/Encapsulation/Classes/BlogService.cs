using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Classes
{
    class BlogService : Blogs
    {
        // This class is used to publish the blog
        public bool publish(int blogid)
        {
            // search for blogs table with the id and see if you can find.
            // IF you find the blog set is published to true
            ispublished = false;
            if(!ispublished)  // ispublished property is accessible because it is protected 
            {
                // write something to publish the blog       
                Guid newid = Guid.NewGuid();
                Guid oldid = Blogguid; // I can get the blogguid
               // Blogguid = newid; // but it gives me compile time error when I want to set/ assign a value.. Change the access level to 

            }
            return true;
        }

    }
}
