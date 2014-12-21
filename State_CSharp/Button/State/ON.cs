using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Button.State
{
    class ON : ButtonState
    {
        private ON() { }

        private static ON on = new ON();

        public static ButtonState GetInstance()
        {
            return on;
        }
    }
}
