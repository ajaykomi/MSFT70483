using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorImplementation.Rules;

namespace RefactorImplementation.Models
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEgine<Registration>))]
    public class Registration
    {
        public string Userneme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
    }
}
