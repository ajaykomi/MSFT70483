using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Constructors
{
    public class McDonalds : FFRestaurant
    {
        public McDonalds()
        {

        }
        public McDonalds(int mccomboid) : base(mccomboid) { }

        public void ordercombo()
        {
            base.ComboID = 5;
        }

        // This is override method which is inherited and overriden.
        // Methods can overriden only if the parent method is marked as Virtual

         //   Creating the method in a derived class with same name, same parameters and same return type as in base class is called as method overriding.
        //Method overriding is the example of run time polymorphism,how its is the part of run time polymorphism i will explain in detail.
        //  Method overriding is only possible in derived class not within the same class where the method is declared.
        //  Only those methods are overrides in the derived class which is declared in the base class with the help of virtual keyword or abstract keyword.
        public override decimal CalculatePrice(int nmeals, decimal price)
        {
            return nmeals > 5 ? (nmeals * price) -5 : nmeals * price;
          
        }
        
    }
}
