using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Variables
    {
        public static double Salary;//static variables
        public static string Name = "Aniket";
        public string EmployeeName;//Instance or Non Static Variables
        public int EmployeeId;
        public const float Monthlysalary = 20000;
        public readonly string LastName;//ReadOnly
        public Variables()
        {
            
            this.LastName = "Gamechanger";
        }
        public void EmployeeAge()
        {
            int age = 20;//Local Variables
            Console.WriteLine(" Marks of Student :" + age);

        }
    }
}
