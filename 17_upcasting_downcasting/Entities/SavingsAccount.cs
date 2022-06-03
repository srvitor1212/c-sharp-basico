namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } // taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // sealed = selar, não pode sobreescrever esse método, pois já foi sobrescrito uma vez
        {
            base.Withdraw(amount); //usa o método da super classe
            Balance -= 2;
            //Balance -= amount;
        }
    }
}
