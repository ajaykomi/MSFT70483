using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Constructors
{
    // FFRestaurant - Fast food restaurant class
    public class FFRestaurant
    {
        // Default constructor
        public FFRestaurant(){}

        // Parameter constructor
        public FFRestaurant( int id)
        {
            this.ComboID = id;
        }

        public int ComboID { get; set; }
        public String Meal { get; set; }
        public string Drink { get; set; }
        public string Desert { get; set; }
        public decimal Price { get; set; }

        public virtual decimal CalculatePrice(int numberofmeals, decimal price)
        {
            return price * numberofmeals;
        }
    }
}
