using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction
{
    public interface ISyntaxNode
    {
        string ToStringValue();
        double GetResult(double x);
        bool IsDomainOfFunction(double x);
    }
}
