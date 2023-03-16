namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables Types");
            Variables variables = new Variables();
            variables.EmployeeAge();//Local
            Variables.Salary = 46000;//Static
            Console.WriteLine("Employee Salary = " + Variables.Salary);
            Console.WriteLine("Employee Salary = " + Variables.Monthlysalary);//Const variable
            Console.WriteLine("Employee LastName;" + variables.LastName);//readomnly
            variables.EmployeeName = "Aniket";//Instance 
            variables.EmployeeId = 1;
            Console.WriteLine("Employee Name= " + variables.EmployeeName + " \nEmployee ID; " + variables.EmployeeId);
            Variables variables1 = new Variables();
            variables1.EmployeeName = "Sky";//Instance Second Object
            variables1.EmployeeId = 2;
            Console.WriteLine("Employee Name= " + variables1.EmployeeName + " \nEmployee ID; " + variables1.EmployeeId);
        }
    }
}