namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option:-> 1.OverLoadingMethod 2.OverRidingAnimal");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    OverLoadingMethod add = new OverLoadingMethod();
                    add.Add(4, 5);
                    add.Add(6.7f, 7.4f);
                    add.Add(7, 6.7f, 7.4f);
                    add.Add(6.7f, 5, 7.4f);
                break;

                case 2:
                    OverRidingAnimal overRidingAnimal = new OverRidingAnimal();
                    overRidingAnimal.eat();
                break;
            }
            
        }
    }
}