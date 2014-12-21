using State_CSharp.ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do something usual\n");
            ATMMachine atmMachine = new ATMMachine();
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(10000);
            atmMachine.EjectCard();

            Console.WriteLine("\n\n\nDo something unusual\n");
            atmMachine.RequestCash(10000);
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(10000);
            atmMachine.EjectCard();
        }
    }
}
