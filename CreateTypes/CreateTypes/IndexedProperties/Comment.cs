using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.IndexedProperties
{
    public class Comment
    {
        public int blogid { get; set; }
        public string Commenttext { get; set; }
        public DateTime? Commentdate { get; set; }

        public Comment(int id, string comment, DateTime commentdate)
        {
            this.blogid = id;
            this.Commenttext = comment;
            this.Commentdate = commentdate;
        }
     
    }
}
