using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Postman();
            worker.DailyRoutine();

            worker = new Manager();
            worker.DailyRoutine();
        }
    }
}
