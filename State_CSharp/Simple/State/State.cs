using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp
{
    abstract class State
    {
        abstract public void GoNextState(Context context);
    }
}
