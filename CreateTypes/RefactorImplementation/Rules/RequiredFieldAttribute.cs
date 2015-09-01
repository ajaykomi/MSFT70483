using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorImplementation.RulesEngine;

namespace RefactorImplementation.Rules
{
   [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    public class RequiredAttribute : ValidationAtrribute
    {
        public string Name { get; set; }
        public string Message { get; set; }

       public RequiredAttribute () : base(){}

        public RequiredAttribute(string name, string message): base(name, message)
        {
            this.Name = name;
            this.Message = message;
        }

        public override BrokenRule Validate(object value, RulesEngine.ValidationContext context)
        {
            BrokenRule rule = new BrokenRule();
            if(value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                rule.IsBroken = true;
                rule.ErrorMessage = this.Message;
                rule.Name = this.Name;
            }

            return rule;
        }
    }
}
