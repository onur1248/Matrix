using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Cos: Function
    {
        public Cos(): base()
        {

        }

        public Cos(ISyntaxNode x): base (x)
        {

        }

        public override double GetResult(double x)
        {
            return Math.Cos(GetX().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetX().IsDomainOfFunction(x);
        }

        public override string ToStringValue()
        {
            return "cos";
        }
    }
}
