namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        protected decimal balace;
        protected decimal interestRate;
        protected DateTime createdOn;
        protected int numberOfMonths;
        protected const decimal interesrRateConst = 10m;
        private CustomerType customer;

        public Account(DateTime date, CustomerType customer, decimal balance)
        {
            this.CreatedOn = date;
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = this.CalculateInterestRate();
            this.NumberOfMonths = this.CalcMonths();
        }

        public CustomerType Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balace; }
            set
            {
                this.balace = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate ;} //= this.CalculateInterestRate(); }
            protected set { this.interestRate = value;}// this.CalculateInterestRate(); }
        }

        public DateTime CreatedOn
        {
            get { return this.createdOn; }
            set { this.createdOn = value; }
        }

        protected int NumberOfMonths
        {
            get { return this.numberOfMonths;}// = this.CalcMonths(); }
             set
            {
                this.numberOfMonths = value;// this.CalcMonths();  // do not work :/
            }
        }

        public enum CustomerType
        {
            Individual, Company
        }

        protected int CalcMonths()
        {
            if (this.CreatedOn > DateTime.Now) throw new ArgumentException("The date of creation of account cannot be in the future!");
            this.numberOfMonths = DateTime.Now.Month - this.CreatedOn.Month + 12 * (DateTime.Now.Year - this.CreatedOn.Year);
            return this.numberOfMonths;
        }

        public abstract decimal CalculateInterestRate();
    }
}