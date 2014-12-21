using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp.Core.State
{
    abstract class StateAbstract
    {
        abstract public void GoNextState(Context context);
    }
}
