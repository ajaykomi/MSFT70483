using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorImplementation.RulesEngine;


namespace RefactorImplementation.Rules
{
    public abstract class ValidationAtrribute : Attribute
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public ValidationAtrribute()
        {

        }

        public ValidationAtrribute(string name, string message)
        {
            this.Name = name;
            this.Message = message;
        }

        public abstract BrokenRule Validate(object value, ValidationContext context);
        
    }
}
