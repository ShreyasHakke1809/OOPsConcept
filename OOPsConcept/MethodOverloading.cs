namespace OOPsConcept
{
    internal class MethodOverloading
    {
        public void Addition(int x, int y)
        {
            int res = x + y;
            Console.WriteLine(res);
        }
        public void Addition(int x, int y, int z)
        {
            int r = x + y + z;
            Console.WriteLine(r);
        }
        public void Addition(int x, int y, float z)
        {
            int c = y + x;
            Console.WriteLine(c);
        }
    }
}
