using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_CSharp.Bakery.Prototype
{
    abstract class Cake
    {
        string name;
        int price;

        public Cake(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract Cake Clone();

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Name: " + name);
            builder.AppendLine("Price: " + price);
            return builder.ToString();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
