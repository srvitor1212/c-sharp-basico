namespace Course.Entities
{
    class Account
    {
        public int Number { get; private set; } //private não pode ser alterado por uma sub classe(herdado), mas por outras sim
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //pode ser alterado por sub classes(herdadas), mas não por outras

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}