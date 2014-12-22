using Composite_CSharp.Arithmetic.Composite;
using Composite_CSharp.Arithmetic.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Expression: 1 + 5 * (4 - 3) * (2 + 1 / 2)
            /// Composite 1: 1 + 5 * (4 - 3) * (2 + 1 / 2)
            ///     Number 1: 1
            ///     Operator 1: +
            ///     Composite 2: 5 * (4 - 3) * (2 + 1 / 2)
            ///         Number 2: 5
            ///         Operator 2: *
            ///         Composite 3: (4 - 3) * (2 + 1 / 2)
            ///             Composite 4: 4 - 3
            ///                 Number 3: 4
            ///                 Operator 3: -
            ///                 Number 4: 3
            ///             Operator 4: *
            ///             Composite 5: 2 + 1 / 2
            ///                 Number 5: 2
            ///                 Operator 5: +
            ///                 Composite 6: 1 / 2
            ///                     Number 6: 1
            ///                     Operator 6: /
            ///                     Number 7: 2

            NumbericOperand number7 = new NumbericOperand(2);
            Operator operator6 = new Division();
            NumbericOperand number6 = new NumbericOperand(1);
            CompositeOperand composite6 = new CompositeOperand(number6, number7, operator6);

            NumbericOperand number5 = new NumbericOperand(2);
            Operator operator5 = new Summation();
            CompositeOperand composite5 = new CompositeOperand(number5, composite6, operator5);

            NumbericOperand number3 = new NumbericOperand(4);
            Operator operator3 = new Subtraction();
            NumbericOperand number4 = new NumbericOperand(3);
            CompositeOperand composite4 = new CompositeOperand(number3, number4, operator3);

            Operator operator4 = new Multiplication();
            CompositeOperand composite3 = new CompositeOperand(composite4, composite5, operator4);

            NumbericOperand number2 = new NumbericOperand(5);
            Operator operator2 = new Multiplication();
            CompositeOperand composite2 = new CompositeOperand(number2, composite3, operator2);

            NumbericOperand number1 = new NumbericOperand(1);
            Operator operator1 = new Summation();
            CompositeOperand composite1 = new CompositeOperand(number1, composite2, operator1);

            Console.WriteLine("1 + 5 * (4 - 3) * (2 + 1 / 2) = " + composite1.Calculate());
        }
    }
}
