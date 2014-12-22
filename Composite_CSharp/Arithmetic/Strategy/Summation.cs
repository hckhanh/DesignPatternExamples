using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_CSharp.Arithmetic.Strategy
{
    class Summation : Operator
    {
        public float Calculate(float leftValue, float rightValue)
        {
            return leftValue + rightValue;
        }
    }
}
