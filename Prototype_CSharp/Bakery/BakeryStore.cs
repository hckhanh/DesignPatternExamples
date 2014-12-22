using Prototype_CSharp.Bakery.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery
{
    class BakeryStore
    {
        public BakeryStore()
        {
            initProtptype();
        }

        public void initProtptype()
        {
            CakeFactory.AddCakePrototype(new Doughnut());
            CakeFactory.AddCakePrototype(new Cheesecake());
            CakeFactory.AddCakePrototype(new RedVelvet());
        }

        public Cake SellCake(string name)
        {
            return CakeFactory.FindAndProduce(name);
        }
        public Cake SellCake(int i)
        {
            return CakeFactory.Produce(i);
        }
    }
}
