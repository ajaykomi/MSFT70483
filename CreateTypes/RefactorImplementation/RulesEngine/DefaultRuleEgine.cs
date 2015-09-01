using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RefactorImplementation.Rules;

namespace RefactorImplementation.RulesEngine
{
    public class DefaultRuleEngine<T> : RuleEngineBase<T>, IRuleEngine<T>
    {

        public List<BrokenRule> Validate(T value)
        {
            List<BrokenRule> results = new List<BrokenRule>();

            PropertyInfo[] props = value.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                var rules = Rules[prop.Name];
                foreach (ValidationAtrribute rule in rules)
                {
                    var ruleResult = rule.Validate(prop.GetValue(value), new ValidationContext { SourceObject = value });
                    if (ruleResult.IsBroken)
                    {
                        results.Add(ruleResult);
                    }
                }
            }
            return results;
        }

        public override void BuildRuleSet()
        {
            Type valType = typeof(T);
            PropertyInfo[] valprops = valType.GetProperties();
            foreach (PropertyInfo valprop in valprops)
            {
                var ruleset = valprop.GetCustomAttributes(typeof(ValidationAtrribute), true);
                List<ValidationAtrribute> lstattributes = new List<ValidationAtrribute>();
                foreach (var valattr in ruleset)
                {
                    lstattributes.Add((ValidationAtrribute)valattr);
                }
                Rules[valprop.Name] = lstattributes;
            }

        }
    }
}
