using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts;
using BankAccounts.Customers;

namespace BankAccounts
{
    public class Customer
    {
        private CustomerType type;
        private string firstname;
        private string lastname;
        private string email;
        private string adress;
        private List<Account> accounts;

        //the constructor should have contact info, but maybe next time
        public Customer(string firstname, string lastname, CustomerType type)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.type = Type;
        }

        public Customer(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                CheckName(value);
                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.firstname; }
            set
            {
                CheckName(value);
                this.lastname = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Adress
        {
            get { return this.adress; }
            set { this.adress = value; }
        }

        public CustomerType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        private void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Enter a name.");
            }
            foreach (char c in name)
            {
                if (!Char.IsLetter(c) && c != ' ' && c != '-')
                {
                    throw new ArgumentException("Invalid name!");
                }
            }
        }

        public override string ToString()
        {
            return String.Format
                ("Account holder: " + this.Firstname + " " + this.Lastname + "\n" + 
                                  "Contact info: " + this.Email + ", " + this.Email);
        }

    }
}
