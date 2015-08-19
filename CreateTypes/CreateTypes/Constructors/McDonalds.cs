using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Constructors
{
    public class McDonalds : FFRestaurant
    {
        public McDonalds(int mccomboid) : base(mccomboid) { }

        public void ordercombo()
        {
            base.ComboID = 5;
        }

        // This is override method which is inherited and overriden.
        // Methods can overriden only if the parent method is marked as Virtual
        public override decimal CalculatePrice(int nmeals, decimal price)
        {            
            if (nmeals > 5)
            {
                return (nmeals * price) - 5;
            }
            else
            {
                return (nmeals * price);
            }
        }
        
    }
}
