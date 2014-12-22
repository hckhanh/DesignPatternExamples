using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery.Prototype
{
    class Cheesecake : Cake
    {
        public Cheesecake() : base("Cheesecake", 32) { }

        public override Cake Clone()
        {
            return (Cake)this.MemberwiseClone();
        }
    }
}
