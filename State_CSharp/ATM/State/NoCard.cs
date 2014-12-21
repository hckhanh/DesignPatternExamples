using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.ATM.State
{
    class NoCard : ATMStateMachine
    {
        public void InsertCard(ATMMachine aTMMachine)
        {
            aTMMachine.ChangeState(new HasCard());
            Console.WriteLine("\tCard is inserted.");
        }

        public void EjectCard(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new NoCard());
            Console.WriteLine("\tNo card to be ejected.");
        }

        public void InsertPin(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new Has());
            Console.WriteLine("\tNo card to be inserted.");
        }

        public void RequestCash(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new HasCard());
            Console.WriteLine("\tNo card to withdraw.");
        }
    }
}
