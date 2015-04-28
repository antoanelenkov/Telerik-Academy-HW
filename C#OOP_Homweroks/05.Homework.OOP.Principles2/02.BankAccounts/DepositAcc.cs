using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class DepositAcc : Account, IDepositable, IWithdrawable
    {
        private const int MAX_BALANCE_WITHOUT_INTEREST = 1000;

        public DepositAcc(Customer customer, DateTime dateCreated, decimal balance, double interestRate)
            : base(customer, dateCreated, balance, interestRate) { }

        public override double CalculateInterestRate(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < MAX_BALANCE_WITHOUT_INTEREST)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * numberOfMonths;
            }
        }



        public void Deposit(decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("You must deposit possitive value of the currency");
            }
            else
            {
                this.Balance += value;
            }
        }

        public void WithDraw(decimal value)
        {
            if (this.Balance - value < 0)
            {
                Console.WriteLine("You do not have this amount, you will get only: {0}", this.Balance);
                this.Balance = 0;
            }
            else
            {
                this.Balance -= value;
            }
        }
    }
}
