namespace OOPsConcept
{
    abstract class Abstraction
    {
        public void WithdrawMoney()
        {
            Console.WriteLine("We can withdraw money from atm");
        }
        public abstract void ConnectingToBackEnd();
    }

    class Atm : Abstraction
    {
        public override void ConnectingToBackEnd()
        {
            Console.WriteLine("Connected t back end");
        }
    }
}
