using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class AbstractAnimal
    {
        // Abstract method does not have a body
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Animal is is Sleeping");
        }
    }

   
    class Pig : AbstractAnimal
    {
        public override void animalSound()
        {
            
            Console.WriteLine("The pig says:- Weeeeee!!!!1");
        }
    }
}
