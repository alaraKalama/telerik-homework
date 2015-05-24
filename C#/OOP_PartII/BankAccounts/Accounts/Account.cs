using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    
    public abstract class Account : I_InterestAmount, IDepositable, IWithdrawable
    {
        private Customer client;
        private decimal balance;
        private decimal interestRate;
        private DateTime dateOfRegister;
        private AccountType type;

        public Account(Customer client, decimal balance, decimal interest)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interest;
            this.dateOfRegister = DateTime.Now;
        }

        public DateTime DateOfRegister
        {
            get { return this.dateOfRegister; }
            private set { this.dateOfRegister = value; }
        }

        public Customer Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate can't be negative.");
                }
                this.interestRate = value; 
            }
        }

        public AccountType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public virtual void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public virtual decimal Withdraw(decimal sum)
        {
            throw new ArgumentException("You can't withdraw from this type of account.");
        }

        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            return String.Format("Account details: " + this.Client.ToString() + "\n" +
                                        "Balance: " + this.Balance + "\n" + "Interest rate: " + this.InterestRate);
        }
    }
}
