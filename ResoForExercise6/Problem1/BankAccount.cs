
namespace Problem1
{
    public class BankAccount
    {
        int money;

        public BankAccount(int amount)
        {
            this.money = amount;
        }

        public void WithDraw(int amount)
        {
            if (amount > 0 && this.money > amount)
            {
                this.money -= amount;
            }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.money += amount;
            }
        }

        public int Balance()
        {
            return this.money;
        }
    }
}
