using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class LoanAcc:Account,IDepositable
    {
        private const int SPEACIAL_NUMBER_OF_MONTHS_INDIVIDUALS = 3;
        private const int SPEACIAL_NUMBER_OF_MONTHS_COMPANIES = 2;

        public LoanAcc(Customer customer, DateTime dateCreated, decimal balance, double interestRate)
            : base(customer, dateCreated, balance, interestRate) { }

        public override double CalculateInterestRate(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                return this.InterestRate * (numberOfMonths - SPEACIAL_NUMBER_OF_MONTHS_INDIVIDUALS);
            }
            if (this.Customer is Company)
            {
                return this.InterestRate * (numberOfMonths - SPEACIAL_NUMBER_OF_MONTHS_COMPANIES);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Deposit(decimal value)
        {
            this.Balance += value;
        }
    }
}
