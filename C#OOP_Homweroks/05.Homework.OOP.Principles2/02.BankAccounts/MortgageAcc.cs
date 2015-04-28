using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class MortgageAcc:Account,IDepositable
    {
        private const int SPEACIAL_NUMBER_OF_MONTHS_INDIVIDUALS = 6;
        private const int SPEACIAL_NUMBER_OF_MONTHS_COMPANIES = 12;
        public MortgageAcc(Customer customer, DateTime dateCreated, decimal balance, double interestRate)
            : base(customer, dateCreated, balance, interestRate) { }

        public override double CalculateInterestRate(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= SPEACIAL_NUMBER_OF_MONTHS_INDIVIDUALS)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (numberOfMonths - SPEACIAL_NUMBER_OF_MONTHS_INDIVIDUALS);
                }

            }
            if (this.Customer is Company)
            {
                if (numberOfMonths <= SPEACIAL_NUMBER_OF_MONTHS_COMPANIES)
                {
                    return this.InterestRate * (numberOfMonths)/2;
                }
                else
                {
                    return (this.InterestRate * (SPEACIAL_NUMBER_OF_MONTHS_COMPANIES) / 2 
                        + this.InterestRate * (numberOfMonths - SPEACIAL_NUMBER_OF_MONTHS_COMPANIES));
                }
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
