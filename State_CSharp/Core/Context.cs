using State_CSharp.Core.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Core
{
    class Context
    {
        StateAbstract currentState;

        void DoSomething()
        {
            currentState.GoNextState(this);
        }

        internal void SetState(StateAbstract state)
        {
            currentState = state;
        }
    }
}
