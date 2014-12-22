using Prototype_CSharp.Bakery;
using Prototype_CSharp.Bakery.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryStore store = new BakeryStore();
            Console.WriteLine("Doughnut(0) Cheesecake(1) Red Velvet(2)");
            Console.Write("Enter the key of cake: ");
            int key = int.Parse(Console.ReadLine());

            Cake cake = store.SellCake(key);
            Console.WriteLine("Sell cake:");
            Console.WriteLine(cake.ToString());
        }
    }
}
