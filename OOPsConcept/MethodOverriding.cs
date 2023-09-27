namespace OOPsConcept
{
    public class MethodOverriding
    {
        public string name;
        public double salary;

        public virtual void GetSalary()
        {
            Console.WriteLine("5000");
        }
    }

    class Employee : MethodOverriding
    {
        public override void GetSalary()
        {
            Console.WriteLine("10000");
        }
    }
}
