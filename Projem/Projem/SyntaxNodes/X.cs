using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class X: ISyntaxNode
    {
        public double GetResult(double x)
        {
            return x;
        }

        public string ToStringValue()
        {
            return "x";
        }

        public bool IsDomainOfFunction(double x)
        {
            return true;
        }
    }
}
