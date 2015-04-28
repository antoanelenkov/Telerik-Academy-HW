namespace BankAccounts
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {

            //var deposit = new Mortgage(DateTime.Parse("16.12.2014"), Account.CustomerType.Individual, 1500m);
            //deposit.CreatedOn = ;           
            //Console.WriteLine(deposit.InterestRate);

            //deposit = new Mortgage(DateTime.Parse("16.12.2013"), Account.CustomerType.Individual, 2000);
            // deposit.CreatedOn = ;
            //Console.WriteLine(deposit.InterestRate);

            //var deposit1 = new Deposit();
            //deposit.CreatedOn = DateTime.Parse("16.12.2013");
            //deposit.Balance = 5240;
            //Console.WriteLine(deposit.InterestRate);
            //Console.WriteLine(deposit.Balance);

            //var deposit2 = new Deposit();
            //deposit.CreatedOn = DateTime.Parse("16.12.2012");
            //deposit.Balance = 6300;
            //Console.WriteLine(deposit.InterestRate);

            var d = new Deposit(DateTime.Parse("2/16/2014"), Account.CustomerType.Individual, 4000m);
            Console.WriteLine(d.InterestRate);
        }
    }
}