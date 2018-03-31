using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Tan: Function
    {
        public Tan(): base()
        {

        }

        public Tan(ISyntaxNode x): base (x)
        {

        }

        public override double GetResult(double x)
        {
            return Math.Tan(GetX().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetX().IsDomainOfFunction(x) && Math.Cos(x) != 0;
        }

        public override string ToStringValue()
        {
            return "tan";
        }
    }
}
