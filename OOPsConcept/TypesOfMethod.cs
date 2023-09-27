namespace OOPsConcept
{
    internal class TypesOfMethod
    {


        //static method
        public static void Addition()
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine(z);
        }
        //instance method
        public void Substraction()
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x - y;
            Console.WriteLine(z);
        }
        //return type method
        public int Multiplication()
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x * y;
            return z;
        }
        //parameterized method
        public void Division(int x, int y)
        {
            int z = x / y;
            Console.WriteLine(z);
        }
    }
}
