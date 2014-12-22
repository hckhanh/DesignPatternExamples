using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_CSharp
{
    class GlobalClass
    {
        private static GlobalClass globalClass;

        private GlobalClass() { }

        public static GlobalClass GetInstance()
        {
            if (globalClass == null) // Lazy Initialization
                globalClass = new GlobalClass();

            return globalClass;
        }
    }
}
