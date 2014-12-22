using Composite_CSharp.Arithmetic.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_CSharp.Arithmetic.Strategy
{
    interface Operator
    {
        float Calculate(float leftValue, float rightValue);
    }
}
