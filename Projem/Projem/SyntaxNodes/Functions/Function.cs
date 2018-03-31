using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    abstract class Function: ISyntaxNode
    {
        private ISyntaxNode x;
        public Function()
        {
        }

        public Function(ISyntaxNode x)
        {
            this.x = x;
        }
        public  ISyntaxNode GetX()
        {
            return x;
        }

        public void SetX(ISyntaxNode x)
        {
            this.x = x;
        }

        public abstract double GetResult(double x);
        public abstract bool IsDomainOfFunction(double x);
        public abstract string ToStringValue();

    }
}
