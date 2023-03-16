namespace TypesOfMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Types Of Methods in C#");
            Class1 class1 = new Class1(); //Object create just because in Class1 we have declare instance Method.
            class1.Animal();
            Class1.Animal2(); //Here we are not creating object directly calling class with static Method which we have declare
        }
    }
}