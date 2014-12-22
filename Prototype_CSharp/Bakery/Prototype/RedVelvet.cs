using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery.Prototype
{
    class RedVelvet : Cake
    {
        public RedVelvet() : base("Red Velvet", 25) { }

        public override Cake Clone()
        {
            return (Cake)this.MemberwiseClone();
        }
    }
}
