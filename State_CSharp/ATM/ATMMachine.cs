using State_CSharp.ATM.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.ATM
{
    class ATMMachine
    {
        int pin;
        int cash;
        ATMStateMachine currentState;

        public ATMMachine()
        {
            currentState = new NoCard();
        }

        public void InsertCard()
        {
            Console.WriteLine("Insert card");
            currentState.InsertCard(this);
        }

        public void EjectCard()
        {
            Console.WriteLine("Eject card");
            currentState.EjectCard(this);
        }

        public void InsertPin(int pinNumber)
        {
            Console.WriteLine("Insert pin");
            pin = pinNumber;
            currentState.InsertPin(this);
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Request cash");
            if (!HasCash())
                currentState = new NoCard();
            else
            cash = cashToWithdraw;

            currentState.RequestCash(this);
        }


        public void ChangeState(ATMStateMachine aTMState)
        {
            currentState = aTMState;
        }

        private bool HasCash()
        {
            return cash % 2 == 0; // I am kidding :D
        }
    }
}
