using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Ctg: Function
    {
        public Ctg(): base()
        {

        }

        public Ctg(ISyntaxNode x): base (x)
        {

        }

        public override double GetResult(double x)
        {
            return 1/Math.Tan(GetX().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetX().IsDomainOfFunction(x);
        }

        public override string ToStringValue()
        {
            return "ctg";
        }
    }
}
