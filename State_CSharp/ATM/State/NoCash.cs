using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.ATM.State
{
    class NoCash : ATMStateMachine
    {
        public void InsertCard(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new NoCard());
            Console.WriteLine("\tCard is already inserted.");
        }

        public void EjectCard(ATMMachine aTMMachine)
        {
            aTMMachine.ChangeState(new NoCard());
            Console.WriteLine("\tCard is ejected.");
        }

        public void InsertPin(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new HasCard());
            Console.WriteLine("\tPin is already inserted.");
        }

        public void RequestCash(ATMMachine aTMMachine)
        {
            //aTMMachine.ChangeState(new HasCard());
            Console.WriteLine("\tNo cash to be withdrawn.");
        }
    }
}
