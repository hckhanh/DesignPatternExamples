using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Button.State
{
    class OFF : ButtonState
    {
        private OFF() { }

        private static OFF off = new OFF();

        public static ButtonState GetInstance()
        {
            return off;
        }

        public override void Push(ButtonMachine button)
        {
            button.SetState(ON.GetInstance());
            Console.WriteLine("\tturning ON");
        }
    }
}
