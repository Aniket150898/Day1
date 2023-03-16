namespace ValueReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueType.TestType();
            ValueType.ChangeValue(100);//calling Methode with giving argument
          
            ReferenceType.TestReference();  
           
        }
    }
}