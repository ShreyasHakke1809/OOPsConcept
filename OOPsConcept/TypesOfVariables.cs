namespace OOPsConcept
{
    internal class TypesOfVariables
    {
        //constant variable
        const int a = 10;
        //staic variable
        static int b = 25;
        //instance variable
        int c = 10;
        public void Addition()
        {
            //local variable
            int d = 10;

            int x = a + b + c + d;
            Console.WriteLine(x);
        }
    }
}
