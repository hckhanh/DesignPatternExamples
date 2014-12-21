using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp
{
    class StateTwo :  State
    {
        public override void GoNextState(Context context)
        {
            context.SetState(new StateThree());
        }
    }
}
