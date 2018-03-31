using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Var : ISyntaxNode
    {
        private double value;

        public Var(double value)
        {
            this.value = value;
        }

        public string ToStringValue()
        {
            return value.ToString();
        }

        public double GetResult(double x)
        {
            return value;
        }

        public bool IsDomainOfFunction(double x)
        {
            return true;
        }
    }
}
