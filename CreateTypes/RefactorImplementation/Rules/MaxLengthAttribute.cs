using RefactorImplementation.RulesEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorImplementation.Rules
{
    public class MaxLengthAttribute : ValidationAtrribute
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public int MaxLength { get; set; }

        public MaxLengthAttribute() : base() {}

        public MaxLengthAttribute(string name, string message, int maxlen) : base( name, message)
        {
            this.Name = message;
            this.Message = message;
            this.MaxLength = maxlen;
        }

        public override BrokenRule Validate(object value, RulesEngine.ValidationContext context)
        {

            BrokenRule rule = new BrokenRule();
            if (value.ToString().Length > MaxLength)
            {
                rule.IsBroken = true;
                rule.Name = this.Name;
                rule.ErrorMessage = this.Message;
            }
            return rule;
        }
    }
}
