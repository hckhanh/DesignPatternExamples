using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CSharp
{
    class Tiger : Animal
    {
        public Tiger(string name) : base(name)
        {
            flyType = new CantFly();
        }

        public override string GetSpeciesName()
        {
            return "Tiger";
        }
    }
}
