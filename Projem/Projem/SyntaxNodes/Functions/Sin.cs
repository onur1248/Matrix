using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Sin: Function
    {
        public Sin(): base()
        {

        }

        public Sin(ISyntaxNode x): base (x)
        {

        }

        public override double GetResult(double x)
        {
            return Math.Sin(GetX().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetX().IsDomainOfFunction(x);
        }

        public override string ToStringValue()
        {
            return "sin";
        }
    }
}
