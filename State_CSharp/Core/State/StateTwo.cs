﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Core.State
{
    class StateTwo :  StateAbstract
    {
        public override void GoNextState(Context context)
        {
            context.SetState(new StateThree());
        }
    }
}
