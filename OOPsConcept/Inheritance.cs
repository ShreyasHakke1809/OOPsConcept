namespace OOPsConcept
{
    public class Inheritance
    {
        string price;
        string colour;
        string model;
        public void Car()
        {
            Console.WriteLine("Price" + price);
            Console.WriteLine("Colour" + colour);
            Console.WriteLine("Model" + model);
        }
    }
    class Maruti : Inheritance
    {
        public double milage;
        public void Suzuki()
        {
            Console.WriteLine("Milage" + milage);
        }
    }
}
