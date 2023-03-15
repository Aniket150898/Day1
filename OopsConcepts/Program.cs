namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Object here");
            Class1 class1 = new Class1(); //Object create just becuse in Class1 we have declare instance Method.
            class1.Animal();
            Class1.Animal2(); //Here we are not creating object directly calling class with static Method which we have declare
        }
    }
}