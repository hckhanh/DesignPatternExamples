using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_CSharp
{
    class Manager :  Worker
    {
        protected override void work()
        {
            Console.WriteLine("Manage the project");
        }

        protected override void relax()
        {
            Console.WriteLine("Go to bar");
        }
    }
}
