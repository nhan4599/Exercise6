
namespace Problem1
{
    public class BankAccount
    {
        private int Money;

        public BankAccount(int amount)
        {
            Money = amount;
        }

        public void WithDraw(int amount)
        {
            if (amount > 0 && Money > amount)
            {
                Money -= amount;
            }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Money += amount;
            }
        }

        public int Balance()
        {
            return Money;
        }
    }
}
