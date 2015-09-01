using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorImplementation.Rules;
using RefactorImplementation.RulesEngine;

namespace RefactorImplementation.Models
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEngine<Registration>))]
    public class Registration
    {
        [Required("Username","User name is required.")]
        [MaxLength("Maxlength" , "Allowed lenght for user name is 15" , 15)]
        public string Userneme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
    }
}
