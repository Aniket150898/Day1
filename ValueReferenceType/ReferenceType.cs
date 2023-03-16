using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceType
{
    internal class ReferenceType
    {
        public static void TestReference()
        {
           Student student = new Student();
           student.Id= 100;
           student.Name= "Aniket";
           Console.WriteLine("Before Modify:-" + student.Id + student.Name);
           ChangeReference(student);
           Console.WriteLine("After Modify:-" + student.Id + student.Name);
        }
        public static void ChangeReference(Student S)
        {
           S.Id= 21;
           S.Name = "Sky";
           Console.WriteLine("Within method:-" + S.Id + S.Name);

        }
    }
}
