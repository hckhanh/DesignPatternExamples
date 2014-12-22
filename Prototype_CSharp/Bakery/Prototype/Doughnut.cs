using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery.Prototype
{
    class Doughnut : Cake
    {
        public Doughnut() : base("Doughnut", 12) { }

        public override Cake Clone()
        {
            return (Cake)this.MemberwiseClone();
        }
    }
}
