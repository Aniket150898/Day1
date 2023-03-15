using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class OverLoadingMethod
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("addition of Two num:-" + a +","+ b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine("addition of Two num:-" + a + "," + b);
        }
        public void Add(int a, float b, float c)
        {
            Console.WriteLine("addition of Two num:-" + a + "," + b + "," + c);
        }
        public void Add(float a, int b, float c)
        {
            Console.WriteLine("addition of Two num:-" + a + "," + b + "," + c);
        }
    }
}
