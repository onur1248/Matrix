using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Log : Function
    {
        public Log(): base()
        {

        }

        public Log(ISyntaxNode x): base (x)
        {

        }

        public override double GetResult(double x)
        {
            return Math.Log(GetX().GetResult(x));
        }

        public override bool IsDomainOfFunction(double x)
        {
            return GetX().IsDomainOfFunction(x) && x > 0;
        }

        public override string ToStringValue()
        {
            return "log";
        }
    }
}
