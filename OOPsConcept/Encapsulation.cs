namespace OOPsConcept
{
    public class Encapsulation
    {
        private int accountBalance = 180000;

        /* public void setBalance(int balance)
         {
             if (balance < 0)
             {
                 Console.WriteLine("Balance should be greter than zero");
             }
             else
             {
                 accountBalance = balance;
             }
         }
         public void getBalance()
         {
             Console.WriteLine("Your account balance is " + accountBalance);
         }*/

        public int getAccountBalance
        {
            set
            {
                if (accountBalance < 0)
                {
                    Console.WriteLine("Balance should be greter than zero");
                }
                else
                {
                    accountBalance = value;
                }
            }
            get
            {
                return accountBalance;
            }
        }
    }
}
