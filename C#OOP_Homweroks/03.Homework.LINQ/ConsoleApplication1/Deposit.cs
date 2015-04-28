namespace BankAccounts
{
    using System;
    public class Deposit : Account
    {
        public Deposit(DateTime date, CustomerType customer, decimal balance)
            : base(date, customer, balance)
        {
            this.InterestRate = this.CalculateInterestRate();
        }

        public override decimal CalculateInterestRate()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            { throw new ArgumentException("Deposit accounts have no interest if their balance is positive and less than 1000."); }

            return (decimal)this.NumberOfMonths * interesrRateConst;
        }
    }
}