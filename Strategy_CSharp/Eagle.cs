using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CSharp
{
    class Eagle : Animal
    {
        public Eagle(string name) : base(name)
        {
            flyType = new CanFly();

        }

        public override string GetSpeciesName()
        {
            return "Eagle";
        }
    }
}
