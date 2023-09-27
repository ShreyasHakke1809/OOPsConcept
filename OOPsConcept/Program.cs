namespace OOPsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Class and Object\n2.Inheritance\n3.Method Overloading\n4.Method Overriding" +
                "\n5.Encapsulation\n6.Abstraction\n7.Types of variables\n8.Types of method\n9.Value type Reference type\n10.Types of inheritance\n11.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ClassObject classObject = new ClassObject();
                        classObject.Addition();
                        break;
                    case 2:
                        Inheritance inheritance = new Inheritance();
                        Maruti maruti = new Maruti();
                        maruti.milage = 25;
                        maruti.Suzuki();
                        maruti.Car();
                        break;
                    case 3:
                        MethodOverloading methodOverloading = new MethodOverloading();
                        methodOverloading.Addition(09, 18, 27);
                        break;
                    case 4:
                        MethodOverriding overriding = new MethodOverriding();
                        overriding.GetSalary();
                        break;
                    case 5:
                        Encapsulation encapsulation = new Encapsulation();
                        //int balance = Convert.ToInt32(Console.ReadLine());

                        int x = encapsulation.getAccountBalance = 30000;
                        Console.WriteLine("Account balance is " + x);
                        break;
                    case 6:
                        //Abstraction abstraction = new Abstraction();
                        Atm atm = new Atm();
                        atm.ConnectingToBackEnd();
                        atm.WithdrawMoney();
                        break;
                    case 7:
                        TypesOfVariables typesOfVariables = new TypesOfVariables();
                        typesOfVariables.Addition();
                        break;
                    case 8:
                        TypesOfMethod.Addition();
                        TypesOfMethod typesOfMethod = new TypesOfMethod();
                        typesOfMethod.Substraction();
                        typesOfMethod.Multiplication();
                        typesOfMethod.Division(10, 20);
                        break;
                    case 9:
                        ValueAndReferenceType valueAndReferenceType = new ValueAndReferenceType();
                        valueAndReferenceType.ValueType();
                        valueAndReferenceType.ReferenceType();
                        break;
                    case 10:
                        Dogs dogs = new Dogs();
                        dogs.Bark();
                        dogs.Eat();

                        Child child = new Child();
                        child.GrandparentMethod();
                        child.ParentMethod();
                        child.ChildMethod();

                        Cats cats = new Cats();
                        cats.Eat();
                        cats.Meow();

                        Airplane airplane = new Airplane();
                        airplane.Start();
                        airplane.Stop();
                        airplane.TakeOff();
                        airplane.Land();
                        break;
                    case 11:
                        Environment.Exit(0);
                        break;
                    case 12:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}