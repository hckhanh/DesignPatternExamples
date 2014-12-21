using State_CSharp.Button.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Button
{
    public class ButtonMachine
    {
        ButtonState currentState;

        public ButtonMachine()
        {
            currentState = OFF.GetInstance();
        }

        public void Push()
        {
            currentState.Push(this);
        }

        public void SetState(ButtonState buttonState)
        {
            currentState = buttonState;
        }
    }
}
