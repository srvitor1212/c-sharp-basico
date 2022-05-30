namespace Course.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; } //loan é empréstimo

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //re usa as atribuições da classe herdada
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}