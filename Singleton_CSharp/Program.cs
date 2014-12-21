using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalClass global1 = GlobalClass.GetInstance();
            GlobalClass global2 = GlobalClass.GetInstance();

            if (global1 == global2)
            {
                Console.WriteLine("Two objs are the same.");
            }
        }
    }
}
