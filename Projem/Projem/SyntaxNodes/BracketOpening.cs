using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class BracketOpening : ISyntaxNode
    {
        public string ToStringValue()
        {
            return "(";
        }

        public double GetResult(double x)
        {
            return 0;
        }

        public bool IsDomainOfFunction(double x)
        {
            return true;
        }
    }
}
