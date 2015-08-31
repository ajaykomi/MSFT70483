using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RefactorImplementation.Rules;

namespace RefactorImplementation.RulesEngine
{
    public class DefaultRuleEgine<T> : RuleEngineBase<T>, IRuleEngine<T>
    {
        public List<BrokenRule> Validate(T value)
        {
            throw new NotImplementedException();
        }

        public override void BuildRuleSet()
        {
            Type valType = typeof(T);
            PropertyInfo[] valprops = valType.GetProperties();
            foreach (PropertyInfo valprop in valprops)
            {
                var ruleset = valprop.GetCustomAttributes(typeof(ValidationAtrribute), true);
            }
           //throw new NotImplementedException();
        }
    }
}
