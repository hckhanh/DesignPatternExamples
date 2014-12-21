using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CSharp
{
    class CantFly : FlyType
    {
        public void Fly()
        {
            Console.Write("can't fly");
        }
    }
}
