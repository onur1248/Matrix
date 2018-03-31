using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Neg: UnaryOperation
    {
        public Neg(): base()
        {

        }

        public Neg(ISyntaxNode a): base (a)
        {

        }

        public override double GetResult(double x)
        {
            return -GetA().GetResult(x);
        }

        public override string ToStringValue()
        {
            return "--";
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetA().IsDomainOfFunction(x);
        }
    }
}
