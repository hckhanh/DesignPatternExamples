using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Tiger("Sala");
            Animal eagle = new Eagle("Moda");

            Introduce(tiger);
            Console.WriteLine();
            Introduce(eagle);
        }

        private static void Introduce(Animal animal)
        {
            Console.WriteLine("Hello, I am " + animal.GetName());
            Console.WriteLine("I am a " + animal.GetSpeciesName());
            Console.Write("I ");
            animal.Fly();
            Console.WriteLine();
        }
    }
}
