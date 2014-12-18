using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_CSharp
{
    class Postman :  Worker
    {
        protected override void work()
        {
            Console.WriteLine("Distribute letters");
        }
    }
}
