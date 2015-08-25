using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.IndexedProperties
{
    public class CommentDB
    {

         //Indexed properties allow you to use a class that represents an array-like collection of several different kinds of things.
        Dictionary<string, double> items = new Dictionary<string, double>()
        {
            {"SKU1234", 30.0},
            {"SKU1235", 15.0},
            {"SKU1236", 20.0}
        };
       
        public CommentDB()
        {
            List<Comment> commentdb = new List<Comment>{
                AddComment(1, "", DateTime.Now),
              AddComment( 2, "", DateTime.Now)
            };
        }
        

        public Comment AddComment(int id, string comment, DateTime commentdate)
        {
            return new Comment(id, comment, commentdate);
        }

        // This is how to denote a property that can be accessed with the index.. but the below code is not an ideal since it is instatiating a constructor that 
        // creates list of objects and can not be retrieved by its index.
        public Comment this[int id] 
        { 
            get 
            {
                    CommentDB db = new CommentDB();
                    return db[id];                   
            }
        }

        // This is how to denote a property that can be accessed witht he index
       public double this[string key]
        {
            get { return items[key]; }
           
        }
        
    }
}
