using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorImplementation.RulesEngine
{
    interface IRuleEngine<T>
    {
        List<BrokenRule> Validate(T value);
    }
}
