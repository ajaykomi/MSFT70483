using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorImplementation.Rules;

namespace RefactorImplementation.RulesEngine
{
    public abstract class RuleEngineBase<T>
    {
        public Dictionary<string, List<ValidationAtrribute>> Rules {get; set;}

        public RuleEngineBase()
        {
            Rules = new Dictionary<string, List<ValidationAtrribute>>();
            BuildRuleSet();
        }

        public abstract void BuildRuleSet(); // This will be implemented in derived class
    }
}
