using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorImplementation.Rules
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class RuleEngineTypeAttribute : Attribute
    {
        public Type RuleType { get; set; }

        public RuleEngineTypeAttribute() : base(){}
    }
}
