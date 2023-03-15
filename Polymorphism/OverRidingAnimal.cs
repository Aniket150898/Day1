using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class OverRidingAnimal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : OverRidingAnimal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
}
