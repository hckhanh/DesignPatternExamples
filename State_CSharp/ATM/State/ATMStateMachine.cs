using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.ATM.State
{
    interface ATMStateMachine
    {
        void InsertCard(ATMMachine aTMMachine);

        void EjectCard(ATMMachine aTMMachine);

        void InsertPin(ATMMachine aTMMachine);

        void RequestCash(ATMMachine aTMMachine);
    }
}
