namespace OOPsConcept
{
    internal class TypesOfInheritance
    {
        //Types of inheritence
    }
    // Single inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }



    //multilevel inheritance
    class Grandparent
    {
        public void GrandparentMethod()
        {
            Console.WriteLine("Grandparent method.");
        }
    }

    class Parent : Grandparent
    {
        public void ParentMethod()
        {
            Console.WriteLine("Parent method.");
        }
    }

    class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine("Child method.");
        }
    }


    //. Hierarchical Inheritance:
    class Animals
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    class Dogs : Animals
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class Cats : Animals
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing.");
        }
    }

    //multiple inheritance

    interface IDriveable
    {
        void Start();
        void Stop();
    }

    interface IFlyable
    {
        void TakeOff();
        void Land();
    }

    class Car : IDriveable
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    class Airplane : IDriveable, IFlyable
    {
        public void Start()
        {
            Console.WriteLine("Airplane started.");
        }

        public void Stop()
        {
            Console.WriteLine("Airplane stopped.");
        }

        public void TakeOff()
        {
            Console.WriteLine("Airplane took off.");
        }

        public void Land()
        {
            Console.WriteLine("Airplane landed.");
        }
    }
}
