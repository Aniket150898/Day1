using System.Security.Principal;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Account myaccount = new Account();
            myaccount.SetBalance(100);
            myaccount.GetBalance();
        }
    }
}