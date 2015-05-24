using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    class LoanAccount : Account
    {
        private const int IndividualLoanInterest = 3;
        private const int CompanyLoanInterest = 2;

        public LoanAccount(Customer client, decimal balance, decimal interest)
            : base (client, balance, interest)
        {
            this.Type = AccountType.Loan;
            //this.Client.Accounts.Add(new LoanAccount(this.Client, this.Balance, this.InterestRate)); //?
            //I want to automatically add the created account to the list of accounts of the customer, but I think this will 
            //create just two accounts with the same things inside, and things would mess up with the first withdraw or deposit.
        }

        public override decimal InterestAmount(int months)
        {
            if (this.Client.Type == Customers.CustomerType.Individual)
            {
                return this.InterestRate * (months - IndividualLoanInterest);
            }
            else
            {
                return this.InterestRate * (months - CompanyLoanInterest);
            }
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "\nAccount type: " + this.Type);
        }
    }
}
