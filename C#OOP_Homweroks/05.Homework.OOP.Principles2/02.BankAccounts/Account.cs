using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    interface IDepositable
    {
        void Deposit(decimal value);
    }

    interface IWithdrawable
    {
        void WithDraw(decimal value);
    }

    abstract class Account 
    {
        private Customer customer;
        private DateTime accountCreated;
        private decimal balance;
        private double interestRate;

        public Account(Customer customer, DateTime accCreated, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.accountCreated = accCreated;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public DateTime AccountCreated
        {
            private set
            {
                if (value > DateTime.Now){throw new IndexOutOfRangeException("You can not make user with date in the future!");}
                else{this.accountCreated = value;}
            }
            get { return this.accountCreated; }
        }
        public double InterestRate
        {
            get
            { return interestRate; }
            set
            {
                if (value < 0) { throw new IndexOutOfRangeException("Interest rate must be non-negative value!"); }
                else { this.interestRate = value; }
            }
        }
        public decimal Balance
        {
            get{return balance;}
            set
            {
                if (value < 0){throw new IndexOutOfRangeException("Balance must be non-negative value!");}
                else{this.balance = value;}
            }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public abstract double CalculateInterestRate(int numberOfMonths);
    }
}
