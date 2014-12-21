using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp
{
    class Context
    {
        State currentState;

        void DoSomething()
        {
            currentState.GoNextState(this);
        }

        internal void SetState(State state)
        {
            currentState = state;
        }
    }
}
