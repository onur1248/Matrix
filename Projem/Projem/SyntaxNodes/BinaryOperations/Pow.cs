using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Pow : BinaryOperation
    {
        public Pow()
        {

        }

        public Pow(ISyntaxNode a, ISyntaxNode b)
            : base(a, b)
        {

        }

        public override string ToStringValue()
        {
            return "^";
        }

        public override double GetResult(double x)
        {
            return Math.Pow(GetA().GetResult(x) , GetB().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            if (GetB().GetResult(x) % 1 != 0 && GetA().GetResult(x) < 0) return false;
            return GetA().IsDomainOfFunction(x) && GetB().IsDomainOfFunction(x);
        }
    }
}
