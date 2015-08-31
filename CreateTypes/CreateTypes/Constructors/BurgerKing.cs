using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Constructors
{
    public class BurgerKing : FFRestaurant
    {
       //  Implementing diffrent types of constructors invoking
        public Guid _guid;

        public BurgerKing()
        {
            this._guid = Guid.NewGuid();
        }

        public BurgerKing() :this(null) {} // This is another type of constuctor that call the constructor in the same class
        public BurgerKing(string name){}

    }
}
