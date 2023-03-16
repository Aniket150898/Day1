using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceType
{
    internal class ValueType
    {
        public static void TestType()
        {
            int x = 100;
            Console.WriteLine("Before Modify value of x:-"+ x);
            ChangeValue(x);
            Console.WriteLine("After Modify value of x:-" + x);
        }
        public static void ChangeValue(int x)
        {
            x = x + 20;
            Console.WriteLine("Within method value of x:-" + x);
        }
    }
}
