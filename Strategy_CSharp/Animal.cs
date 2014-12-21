using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CSharp
{
    abstract class Animal
    {
        string name;
        protected FlyType flyType;

        public Animal(string name)
        {
            this.name = name;
        }

        public bool cantFly()
        {
            return this.flyType is CantFly;
        }

        public abstract string GetSpeciesName();

        public string GetName()
        {
            return name;
        }

        public void Fly()
        {
            flyType.Fly();
        }
    }
}
