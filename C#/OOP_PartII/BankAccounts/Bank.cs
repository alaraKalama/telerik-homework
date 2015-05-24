using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts;
using BankAccounts.Customers; 

namespace BankAccounts
{
    public class Bank
    {
        private string name;
        private string adress;
        private HashSet<Account> accounts;

        public Bank(string name, string adress)
        {
            this.Name = name;
            this.Adress = adress;
            this.Accounts = new HashSet<Account> ();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Adress
        {
            get { return this.adress; }
            set { this.adress = value; }
        }

        public HashSet<Account> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public void CloseAccount(Account account)
        {
            if (this.Accounts.Contains(account))
            {
                this.Accounts.Remove(account);
            }
            else
            {
                throw new ArgumentNullException("Account doesn't exist.");
            }
        }
    }
}
