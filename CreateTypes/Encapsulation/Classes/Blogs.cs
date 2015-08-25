using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation.Classes
{
   public class Blogs
    {
       private int blogid;
       public string blogpost;
       public int rating;
       protected bool ispublished;
       internal string blogger;

       private Guid blogguid;
       public Guid Blogguid
       {
           get { return blogguid; }
           private set { blogguid = value; }
       }

       public Blogs(){}

       public Blogs(int id)
       {
           this.blogid = id;
       }


    }
}
