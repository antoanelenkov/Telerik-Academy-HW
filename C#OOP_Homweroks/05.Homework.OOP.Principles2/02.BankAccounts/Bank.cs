using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Bank
    {
        private string name;
        private IList<Account> accountsCollection;

        public Bank(string name, IList<Account> accountsCollection)
        {
            this.Name = name;
            this.AccountsCollection = accountsCollection;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public IList<Account> AccountsCollection
        {
            get { return accountsCollection; }
            set { accountsCollection = value; }
        }      
    }
}
