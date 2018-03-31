using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFunction.SyntaxNodes
{
    class Div: BinaryOperation
    {
        public Div()
        {

        }

        public Div(ISyntaxNode a, ISyntaxNode b)
            : base(a, b)
        {

        }

        public override string ToStringValue()
        {
            return "/";
        }

        public override double GetResult(double x)
        {
            Console.WriteLine("GetResult");
            double res = GetA().GetResult(x) / GetB().GetResult(x);
            Console.WriteLine("END GetResult");
            return GetA().GetResult(x) / GetB().GetResult(x);
        }

        public override bool IsDomainOfFunction(double x)
        {
            Console.WriteLine(" b = " + GetB().GetResult(x));
            if (GetA().IsDomainOfFunction(x) && GetB().IsDomainOfFunction(x) && GetB().GetResult(x) >= double.MinValue)
                return true;
            return false;
        }
    }
}