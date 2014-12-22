using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery.Prototype
{
    static class CakeFactory
    {
        static Cake[] cakes = new Cake[3];
        static int total = 0;

        static public void AddCakePrototype(Cake cake)
        {
            cakes[total++] = cake;
        }

        static public Cake FindAndProduce(string name)
        {
            int size = cakes.Length;
            for (int i = 0; i < size; i++)
            {
                if (cakes[i].Name == name)
                    return Produce(i);
            }
            return null;
        }

        static public Cake Produce(int i)
        {
            return cakes[i].Clone();
        }
    }
}
