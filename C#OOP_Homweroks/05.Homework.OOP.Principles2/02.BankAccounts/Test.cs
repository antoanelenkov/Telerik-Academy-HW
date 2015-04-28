using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Test
    {
        static void Main(string[] args)
        {
            //Add some customers
            var Antoan = new Individual("Antoan Elenkov");
            var Georgi = new Individual("Georgi Ivanov");
            var Mtel = new Company("Mtel");
            var Telenor = new Company("Telenor");
            //Add some Accounts
            var IndividualAcc1 = new DepositAcc(Antoan, new DateTime(14, 5, 24), 1100, 0.5);
            var IndividualAcc2 = new DepositAcc(Mtel, new DateTime(12, 5, 24), 500, 0.4);
            var companyAcc1 = new DepositAcc(Georgi, new DateTime(13, 5, 24), 5500.5m, .2);
            var companyAcc2 = new LoanAcc(Telenor, new DateTime(12, 5, 24), 500, .6);

            //Initialize bank - not needed
            var FIB = new Bank("FIB", new List<Account>());
            FIB.AccountsCollection.Add(IndividualAcc1);
            FIB.AccountsCollection.Add(IndividualAcc2);
            FIB.AccountsCollection.Add(companyAcc1);
            FIB.AccountsCollection.Add(companyAcc2);

            //Individual Deposit account
            Console.WriteLine("\nIndividual Deposit account");
            Console.WriteLine("Interest rate: {0}",IndividualAcc1.CalculateInterestRate(3));
            Console.WriteLine("Balance before : {0}", IndividualAcc1.Balance);
            IndividualAcc1.Deposit(100000);
            Console.WriteLine("Balance after : {0}", IndividualAcc1.Balance);
            Console.WriteLine("Balance before : {0}", IndividualAcc1.Balance);
            IndividualAcc1.WithDraw(50000);
            Console.WriteLine("Balance after : {0}", IndividualAcc1.Balance);

            //Company Deposit account
            Console.WriteLine("\nCompany Deposit account");
            Console.WriteLine("Interest rate: {0}", companyAcc1.CalculateInterestRate(3));
            Console.WriteLine("Balance before : {0}", companyAcc1.Balance);
            companyAcc1.Deposit(6000);
            Console.WriteLine("Balance after : {0}", companyAcc1.Balance);
            Console.WriteLine("Balance before : {0}", companyAcc1.Balance);
            companyAcc1.WithDraw(100000);
            Console.WriteLine("Balance after : {0}", companyAcc1.Balance);

            //If you want, you can make some more tests :)))
        }
    }
}
