using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_CSharp.Arithmetic.Composite
{
    class NumbericOperand : ArithmeticExpression
    {
        float leafValue;

        public NumbericOperand(float leafValue)
        { 
            this.leafValue = leafValue;
        }

        public override float Calculate()
        {
            return leafValue;
        }
    }
}
