namespace OOPsConcept
{
    internal class ValueAndReferenceType
    {
        public void ValueType()
        {
            int x = 5; // x is a value type
            int y = x; // y is a new copy of the value stored in x
            x = 10;    // Modifying x doesn't affect y

            Console.WriteLine($"x: {x}"); // Output: x: 10
            Console.WriteLine($"y: {y}"); // Output: y: 5
        }
        public void ReferenceType()
        {
            string a = "Hello";   // a is a reference type
            string b = a;         // b now references the same memory location as a
            a = "World";          // Changing a does not affect b

            Console.WriteLine($"a: {a}"); // Output: a: World
            Console.WriteLine($"b: {b}"); // Output: b: Hello
        }
    }
}
