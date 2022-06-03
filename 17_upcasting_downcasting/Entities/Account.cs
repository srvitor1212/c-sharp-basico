namespace Course.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // virtual = esse método pode ser sobre escreito com override
        {
            Balance -= amount + 5.0; // R$ 5 de taxa
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
