using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Button.State
{
    public abstract class ButtonState
    {
        public virtual void Push(ButtonMachine button)
        {
            button.SetState(OFF.GetInstance());
            Console.WriteLine("\tturning OFF");
        }
    }
}
