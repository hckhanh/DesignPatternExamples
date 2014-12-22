using Composite_CSharp.Arithmetic.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_CSharp.Arithmetic.Composite
{
    class CompositeOperand : ArithmeticExpression
    {
        ArithmeticExpression leftExpress;
        ArithmeticExpression rightExpress;
        Operator op;

        public CompositeOperand(ArithmeticExpression leftExpress, ArithmeticExpression rightExpress, Operator op)
        {
            this.leftExpress = leftExpress;
            this.rightExpress = rightExpress;
            this.op = op;
        }

        public override float Calculate()
        {
            return op.Calculate(leftExpress.Calculate(), rightExpress.Calculate());
        }
    }
}
